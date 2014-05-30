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
        readonly Builder builder;
        readonly PredicateRawBuffer predicateRawBuffer;
        readonly ElementWalkerContext elementWalkerContext;
        readonly SubjectElementWalkerFactory subjectElementWalkerFactory = new SubjectElementWalkerFactory();
        readonly PredicateElementWalkerFactory predicateElementWalkerFactory = new PredicateElementWalkerFactory();
        bool addCopyAny = true;
        Stack<OpenSentence> open = new Stack<OpenSentence>();

        public Walker(Builder builder)
        {
            this.builder = builder;
            this.predicateRawBuffer = new PredicateRawBuffer(builder);
            this.elementWalkerContext = new ElementWalkerContext(builder: builder,
                predicateRawBuffer: predicateRawBuffer, walkSubjectElements: WalkSubjectElements);
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
            predicateRawBuffer.EscapeNextPredicateElement = false;
            WalkPredicateElements(predicate);
            foreach (var continuationSentence in predicateContinuation)
            {
                predicateRawBuffer.AppendLine();
                WalkPredicateElements(continuationSentence.GetChildren());
            }
            predicateRawBuffer.FlushRawToPredicate();
            builder.EndPredicate();
        }

        void WalkSubjectElements(CommonTree[] children)
        {
            foreach (var child in children)
                WalkElement(child, subjectElementWalkerFactory);
        }

        void WalkPredicateElements(CommonTree[] predicate)
        {
            foreach (var child in predicate)
                WalkElement(child, predicateElementWalkerFactory);
        }

        void WalkElement(CommonTree element, ElementWalkerFactory factory)
        {
            var walker = factory.GetWalkerForElementType(element.Type);
            walker.Walk(element, elementWalkerContext);
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
