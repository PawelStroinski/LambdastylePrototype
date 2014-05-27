using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Antlr.Runtime.Tree;

namespace LambdastylePrototype.Parser
{
    class Walker
    {
        const int spacesPerTab = 8;
        const string itemIndex = @"^item\s*\[\s*(\d+)\s*\]$";
        const char pipe = '|';
        const char ampersand = '&';
        const char hash = '#';
        const char backslash = '\\';
        readonly Builder builder;
        readonly StringBuilder predicateRawBuffer = new StringBuilder();
        bool addCopyAny = true;
        Stack<OpenSentence> open = new Stack<OpenSentence>();
        bool escapeNextPredicateElement;

        public Walker(Builder builder)
        {
            this.builder = builder;
        }

        public void Walk(CommonTree tree)
        {
            var sentences = tree.GetChildren().Where(child => child.Type == LambdastyleTryParser.SENTENCE).ToArray();
            builder.StartStyle();
            WalkSentences(sentences);
            AddCopyAnyIfRequired();
            builder.EndStyle();
        }

        void WalkSentences(CommonTree[] sentences)
        {
            if (LastSentenceIsSkipAny(sentences))
            {
                sentences = sentences.ExceptLast().ToArray();
                addCopyAny = false;
            }
            for (int i = 0; i < sentences.Length; i++)
            {
                var sentence = sentences[i];
                var indentation = GetIndentationInSpaces(sentence);
                var hasSubject = HasSubject(sentence);
                var childSentence = open.Any() && indentation > open.Peek().Indentation && open.Peek().HasSubject;
                if (open.Any() && !childSentence)
                {
                    Close();
                    while (open.Any() && open.Peek().Indentation >= indentation)
                        Close();
                }
                var predicateContinuationCount = hasSubject ? CountConsecutiveRawIndentedSentencesFromStart(
                    sentences.Skip(i + 1).ToArray(), indentation) : 0;
                var predicateContinuation = sentences.Skip(i + 1).Take(predicateContinuationCount).ToArray();
                i += predicateContinuationCount;
                builder.StartSentence();
                WalkSubjectAndPredicate(sentence, predicateContinuation);
                builder.StartChildren();
                open.Push(new OpenSentence { Indentation = indentation, HasSubject = hasSubject });
            }
            while (open.Any())
                Close();
        }

        void AddCopyAnyIfRequired()
        {
            if (addCopyAny)
            {
                builder.StartSentence();
                builder.StartSubject();
                builder.AddAnyToSubject();
                builder.EndSubject();
                builder.StartPredicate();
                builder.AddOuterIdToPredicate();
                builder.AddOuterValueToPredicate();
                builder.EndPredicate();
                builder.EndSentence();
            }
        }

        bool LastSentenceIsSkipAny(CommonTree[] sentences)
        {
            if (sentences.Any())
            {
                var sentenceChildren = sentences.Last().GetChildren();
                if (sentenceChildren.Length == 1 && sentenceChildren[0].Type == LambdastyleTryParser.SUBJECT)
                {
                    var subjectChildren = sentenceChildren[0].GetChildren();
                    if (subjectChildren.Length == 1 && subjectChildren[0].Type == LambdastyleTryParser.STAR)
                        return true;
                }
            }
            return false;
        }

        void WalkSubjectAndPredicate(CommonTree sentence, CommonTree[] predicateContinuation)
        {
            var children = sentence.GetChildren();
            var subject = children.SingleOrDefault(child => child.Type == LambdastyleTryParser.SUBJECT);
            var predicate = children.Where(child => child != subject).ToArray();
            if (open.Any())
                predicate = predicate.SkipWhile(child => child.Type == LambdastyleTryParser.SPACE).ToArray();
            if (subject != null)
                WalkSubject(subject);
            WalkPredicate(predicate, predicateContinuation);
        }

        void WalkSubject(CommonTree subject)
        {
            builder.StartSubject();
            var children = subject.GetChildren();
            WalkSubjectElements(children);
            if (children.Length == 1 && children[0].Type == LambdastyleTryParser.STAR)
                addCopyAny = false;
            builder.EndSubject();
        }

        void WalkPredicate(CommonTree[] predicate, CommonTree[] predicateContinuation)
        {
            builder.StartPredicate();
            escapeNextPredicateElement = false;
            WalkPredicateElements(predicate);
            foreach (var continuationSentence in predicateContinuation)
            {
                predicateRawBuffer.AppendLine();
                WalkPredicateElements(continuationSentence.GetChildren());
            }
            FlushRawToPredicate();
            builder.EndPredicate();
        }

        void WalkSubjectElements(CommonTree[] children)
        {
            foreach (var child in children)
                WalkSubjectElement(child);
        }

        void WalkSubjectElement(CommonTree element)
        {
            switch (element.Type)
            {
                case LambdastyleTryParser.STRING_LITERAL:
                    var relation = element.Parent.Type == LambdastyleTryParser.EQ
                        || element.Parent.Type == LambdastyleTryParser.NEQ;
                    var rightSideOfRelation = relation && element.ChildIndex == 1;
                    var insideLiteralishSequence = element.Parent.Type == LambdastyleTryParser.LITERALISH_SEQUENCE;
                    if (rightSideOfRelation || insideLiteralishSequence)
                        builder.AddLiteralToSubject(element.Text.WithoutFirstAndLastChar());
                    else
                        builder.AddIdToSubject(element.Text.WithoutFirstAndLastChar());
                    break;
                case LambdastyleTryParser.REGEXP_LITERAL:
                    builder.AddRegExpToSubject(element.Text.WithoutFirstAndLastChar());
                    break;
                case LambdastyleTryParser.NUMBER:
                    builder.AddLiteralToSubject(long.Parse(element.Text));
                    break;
                case LambdastyleTryParser.STAR:
                    builder.AddAnyToSubject();
                    break;
                case LambdastyleTryParser.ITEM:
                    builder.AddItemToSubject();
                    break;
                case LambdastyleTryParser.ITEM_INDEX:
                    var itemIndexResult = Regex.Match(input: element.Text, pattern: itemIndex);
                    if (itemIndexResult.Success)
                        builder.AddItemIndexToSubject(int.Parse(itemIndexResult.Groups[1].Value));
                    else
                        builder.AddItemToSubject();
                    break;
                case LambdastyleTryParser.START:
                    builder.AddStartToSubject();
                    break;
                case LambdastyleTryParser.NULL:
                    builder.AddNullToSubject();
                    break;
                case LambdastyleTryParser.EQ:
                    builder.StartEqualsInSubject();
                    WalkSubjectElements(element.GetChildren());
                    builder.EndEqualsInSubject();
                    break;
                case LambdastyleTryParser.NEQ:
                    builder.StartNotEqualsInSubject();
                    WalkSubjectElements(element.GetChildren());
                    builder.EndNotEqualsInSubject();
                    break;
                case LambdastyleTryParser.DOT:
                    builder.StartPathInSubject();
                    WalkSubjectElements(element.GetChildren());
                    builder.EndPathInSubject();
                    break;
                case LambdastyleTryParser.LSB:
                    builder.StartParentInSubject();
                    WalkSubjectElements(element.GetChildren());
                    builder.EndParentInSubject();
                    break;
                case LambdastyleTryParser.OR:
                    builder.StartOrInSubject();
                    WalkSubjectElements(element.GetChildren());
                    builder.EndOrInSubject();
                    break;
                case LambdastyleTryParser.AND:
                    builder.StartAndInSubject();
                    WalkSubjectElements(element.GetChildren());
                    builder.EndAndInSubject();
                    break;
                case LambdastyleTryParser.E:
                    builder.StartNotInSubject();
                    WalkSubjectElements(element.GetChildren());
                    builder.EndNotInSubject();
                    break;
                case LambdastyleTryParser.OROR:
                    builder.StartShortOrInSubject();
                    WalkSubjectElements(element.GetChildren());
                    builder.EndShortOrInSubject();
                    break;
                case LambdastyleTryParser.LITERALISH_SEQUENCE:
                    builder.StartLiteralishSequenceInSubject();
                    WalkSubjectElements(element.GetChildren());
                    builder.EndLiteralishSequenceInSubject();
                    break;
                default:
                    break;
            }
        }

        void WalkPredicateElements(CommonTree[] predicate)
        {
            foreach (var child in predicate)
                WalkPredicateElement(child);
        }

        void WalkPredicateElement(CommonTree element)
        {
            switch (element.Type)
            {
                case LambdastyleTryParser.OR:
                    FlushRawToPredicate();
                    if (escapeNextPredicateElement)
                        builder.AddRawToPredicate(pipe.ToString());
                    else
                        builder.AddInnerValueToPredicate();
                    break;
                case LambdastyleTryParser.OROR:
                    FlushRawToPredicate();
                    if (escapeNextPredicateElement)
                        builder.AddRawToPredicate(pipe.ToString());
                    else
                        builder.AddInnerValueToPredicate();
                    builder.AddInnerValueToPredicate();
                    break;
                case LambdastyleTryParser.AND:
                    FlushRawToPredicate();
                    if (escapeNextPredicateElement)
                        builder.AddRawToPredicate(ampersand.ToString());
                    else
                        builder.AddOuterValueToPredicate();
                    break;
                case LambdastyleTryParser.HASH:
                    FlushRawToPredicate();
                    if (escapeNextPredicateElement)
                        builder.AddRawToPredicate(hash.ToString());
                    else
                        builder.AddOuterIdToPredicate();
                    break;
                default:
                    predicateRawBuffer.Append(element.Text);
                    break;
            }
            escapeNextPredicateElement = false;
        }

        int GetIndentationInSpaces(CommonTree sentence)
        {
            var children = sentence.GetChildren();
            var spaces = children.TakeWhile(child => child.Type == LambdastyleTryParser.SPACE).ToArray();
            return CountIndentationInSpaces(spaces);
        }

        int CountIndentationInSpaces(CommonTree[] indentation)
        {
            return indentation.Select(space => space.Text == "\t" ? spacesPerTab : 1).Sum();
        }

        bool HasSubject(CommonTree sentence)
        {
            return sentence.GetChildren().Any(child => child.Type == LambdastyleTryParser.SUBJECT);
        }

        int CountConsecutiveRawIndentedSentencesFromStart(CommonTree[] sentences, int currentIndentation)
        {
            var count = 0;
            foreach (var sentence in sentences)
            {
                var children = sentence.GetChildren();
                var indentation = CountIndentationInSpaces(
                    children.TakeWhile(child => child.Type == LambdastyleTryParser.SPACE).ToArray());
                if (HasNoRaw(sentence) || indentation <= currentIndentation)
                    return count;
                else
                    count++;
            }
            return sentences.Length;
        }

        void Close()
        {
            builder.EndChildren();
            builder.EndSentence();
            open.Pop();
        }

        void FlushRawToPredicate()
        {
            if (predicateRawBuffer.Length > 0)
            {
                var raw = predicateRawBuffer.ToString();
                var splet = raw.Split(pipe, ampersand, hash, backslash);
                var position = 0;
                var skipNextChar = false;
                foreach (var item in splet)
                {
                    if (raw.Length <= position)
                        break;
                    var spletAt = raw[position];
                    switch (spletAt)
                    {
                        case pipe:
                            if (!skipNextChar)
                                builder.AddInnerValueToPredicate();
                            skipNextChar = false;
                            position++;
                            break;
                        case ampersand:
                            if (!skipNextChar)
                                builder.AddOuterValueToPredicate();
                            skipNextChar = false;
                            position++;
                            break;
                        case hash:
                            if (!skipNextChar)
                                builder.AddOuterIdToPredicate();
                            skipNextChar = false;
                            position++;
                            break;
                        case backslash:
                            if (!skipNextChar)
                            {
                                if (raw.Length > position + 1)
                                {
                                    var nextChar = raw[position + 1];
                                    switch (nextChar)
                                    {
                                        case '0':
                                            builder.AddRawToPredicate("\0");
                                            break;
                                        case 'a':
                                            builder.AddRawToPredicate("\a");
                                            break;
                                        case 'b':
                                            builder.AddRawToPredicate("\b");
                                            break;
                                        case 'f':
                                            builder.AddRawToPredicate("\f");
                                            break;
                                        case 'n':
                                            builder.AddRawToPredicate("\n");
                                            break;
                                        case 'r':
                                            builder.AddRawToPredicate("\r");
                                            break;
                                        case 't':
                                            builder.AddRawToPredicate("\t");
                                            break;
                                        case 'v':
                                            builder.AddRawToPredicate("\v");
                                            break;
                                        default:
                                            if (Char.IsDigit(nextChar))
                                                builder.AddRegExpGroupToPredicate(int.Parse(nextChar.ToString()));
                                            else
                                                builder.AddRawToPredicate(nextChar.ToString());
                                            break;
                                    }
                                    skipNextChar = true;
                                }
                                else
                                    escapeNextPredicateElement = true;
                            }
                            else
                                skipNextChar = false;
                            position++;
                            break;
                        default:
                            break;
                    }
                    if (item != string.Empty)
                    {
                        if (skipNextChar)
                        {
                            if (item.Length > 1)
                                builder.AddRawToPredicate(item.Substring(1));
                        }
                        else
                            builder.AddRawToPredicate(item);
                        position += item.Length;
                        skipNextChar = false;
                    }
                }
                predicateRawBuffer.Clear();
            }
        }

        bool HasNoRaw(CommonTree sentence)
        {
            return sentence.GetChildren().Any(child => child.Type == LambdastyleTryParser.OR
                || child.Type == LambdastyleTryParser.OROR
                || child.Type == LambdastyleTryParser.AND
                || child.Type == LambdastyleTryParser.HASH
                || child.Type == LambdastyleTryParser.SUBJECT);
        }
    }
}
