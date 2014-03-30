using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter.Subjects;
using LambdastylePrototype.Interpreter.Predicates;
using System.Collections;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter
{
    class Sentence : SyntaxElement
    {
        readonly Subject subject;
        readonly Predicate predicate;
        readonly Sentence[] children;
        ApplyContext context;

        public Sentence(Subject subject, Predicate predicate, params Sentence[] children)
        {
            this.subject = subject;
            this.predicate = predicate;
            this.children = children;
        }

        public Sentence(Predicate predicate)
        {
            this.predicate = predicate;
            this.children = new Sentence[0];
        }

        public virtual void Apply(ApplyContext context)
        {
            this.context = context;
            var appliesAtContext = new AppliesAtContext(context.Position);
            var appliesAtResult = HasSubject ? subject.AppliesAt(appliesAtContext) : new AppliesAtResult(false);
            var isParent = context.ParentScope.IsParent(this);
            if (appliesAtResult.Result || isParent)
            {
                if (context.Silent)
                    return;
                Extension.WriteDebug(context.Position.ToDebugString());
                Extension.WriteDebugLine(appliesAtResult.PositiveLog.ToDebugString());
                if (!isParent && appliesAtResult.PositiveLog.Contains<Parent>())
                {
                    context.ParentScope.ParentFound(this);
                    return;
                }
                context.SentenceScope.Change(context);
                var predicateContext = new PredicateContext(context.GlobalState, context.Position,
                    applyingItem: appliesAtResult.PositiveLog.Contains<Item>(),
                    applyingTail: appliesAtResult.PositiveLog.ContainsTail(),
                    applyingLiteral: appliesAtResult.PositiveLog.ContainsAssignableTo<Literal>(not: typeof(Any)),
                    applyingParent: isParent,
                    applyingOr: appliesAtResult.PositiveLog.Contains<Or>());
                if (predicate.AppliesAt(predicateContext) && !ChildApplies())
                {
                    WritePreviousUntilSubjectOnce();
                    WriteSubjectlessSkippedUntilEnd();
                    var toStringResult = predicate.ToString(predicateContext);
                    context.Write(toStringResult.Result, this, toStringResult.Rewind, toStringResult.SeekBy);
                }
                ApplyChildren();
                return;
            }
            if (context.Style.MoveNext())
                context.Style.Current.Apply(context.Copy(this));
        }

        public void ApplyBOF(ApplyContext context)
        {
            if (predicate.HasOuterId() || predicate.HasOuterValue())
                context.GlobalState.ForceSyntax = !context.GlobalState.ForceSyntax.HasValue;
            if (HasSubject && subject.JustAny() && predicate.HasOuterValue())
                context.GlobalState.ForceSyntax = false;
            if (!HasSubject && !context.Previous.Any(sentence => sentence.HasSubject))
                context.GlobalState.SubjectlessSkippedUntilEnd.Add(this);
            if (HasSubject && subject.JustAny() && predicate.HasOuterId() && predicate.HasOuterValue())
                context.GlobalState.HasCopyAny = true;
            if (context.Style.MoveNext())
                context.Style.Current.ApplyBOF(context.Copy(this));
            else
            {
                if (!context.GlobalState.ForceSyntax.HasValue)
                    context.GlobalState.ForceSyntax = false;
                if (!context.GlobalState.HasCopyAny)
                    context.GlobalState.SubjectlessSkippedUntilEnd.Clear();
            }
        }

        public void ApplyEOF(ApplyContext context)
        {
            if (!HasSubject && !context.Written(this))
                context.Write(predicate.ToString(new PredicateContext(context.GlobalState)).Result, this, true, 0);
            if (context.Style.MoveNext())
                context.Style.Current.ApplyEOF(context);
            else
                if (context.GlobalState.InsertedStartToken.HasValue)
                {
                    var endToken = context.GlobalState.InsertedStartToken == JsonToken.StartObject ? "}" : "]";
                    endToken = (context.GlobalState.WrittenNewLine ? Environment.NewLine : " ") + endToken;
                    context.Write(endToken, this, false, 0);
                }
                else
                    if (context.Position.Last().DelimitersAfter != string.Empty)
                        context.Write(context.Position.Last().DelimitersAfter, this, true, 0);
        }

        bool ChildApplies()
        {
            if (children.Any())
            {
                var afterChildren = new MarkerSentence();
                var childrenAndAfterChildren = children.Concat(afterChildren.Enclose());
                var childrenStyle = childrenAndAfterChildren.Cast<Sentence>().GetEnumerator();
                childrenStyle.MoveNext();
                childrenStyle.Current.Apply(context.Copy(style: childrenStyle, silent: true, caller: this));
                return !afterChildren.Reached;
            }
            else
                return false;
        }

        void ApplyChildren()
        {
            if (children.Any() && !context.SentenceScope.Continues())
                context.Spawn(children);
        }

        void WritePreviousUntilSubjectOnce()
        {
            var previous = PreviousUntilSubjectReversed().Reverse().ToArray();
            var previousNotWritten = previous.Where(sentence => !context.Written(sentence)).ToArray();
            var toWrite = previousNotWritten.Except(context.GlobalState.SubjectlessSkippedUntilEnd);
            foreach (var sentence in toWrite)
                context.Write(sentence.predicate.ToString(new PredicateContext(context.GlobalState)).Result,
                    sentence, true, 0);
        }

        void WriteSubjectlessSkippedUntilEnd()
        {
            var toWrite = context.GlobalState.SubjectlessSkippedUntilEnd;
            var isAtEnd = context.Position.Length == 2 && context.Position.Last().TokenType.IsEnd();
            if (context.Position.Length >= 2 && !isAtEnd)
                context.GlobalState.Last2ndLevelDelimitersBefore = context.Position[1].DelimitersBefore;
            if (!toWrite.Any() || !isAtEnd)
                return;
            var delimitersBefore = context.GlobalState.Last2ndLevelDelimitersBefore;
            if (delimitersBefore == null)
                delimitersBefore = context.Position.Last().DelimitersBefore;
            foreach (var sentence in toWrite)
            {
                if (context.GlobalState.WrittenInThisObject && !delimitersBefore.Contains(","))
                    delimitersBefore = "," + delimitersBefore;
                var value = delimitersBefore + sentence.predicate
                    .ToString(new PredicateContext(context.GlobalState, allowNewLine: false)).Result;
                context.Write(value, sentence, true, 0);
                context.GlobalState.WrittenInThisObject = true;
            }
        }

        void WriteSubjectlessChildrenFromEnd()
        {
            foreach (var sentence in children
                    .SkipWhile(child => child.HasSubject)
                    .Where(child => !child.HasSubject))
                context.Write(sentence.predicate.ToString(new PredicateContext(context.GlobalState)).Result,
                    sentence, true, 0);
        }

        IEnumerable<Sentence> PreviousUntilSubjectReversed()
        {
            foreach (var sentence in context.Previous.Reverse())
                if (sentence.HasSubject)
                    break;
                else
                    yield return sentence;
        }

        bool HasSubject { get { return subject != null; } }
    }
}
