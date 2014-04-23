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
            var appliesAtContext = new AppliesAtContext(position: context.Position, strict: context.Strict,
                startPosition: StartPosition(), isParent: context.ParentScope.IsParent(this), findParent: false);
            if (FindParent(appliesAtContext))
                return;
            var appliesAtResult = HasSubject ? subject.AppliesAt(appliesAtContext) : new AppliesAtResult(false);
            var apply = appliesAtResult.Result && !context.Scan && !SkipStrictCopyBecauseSpawnerCopiedIt();
            if (apply)
            {
                Extension.WriteDebug(context.Position.ToDebugString());
                Extension.WriteDebugLine(appliesAtResult.PositiveLog.ToDebugString());
                context.SentenceScope.Change(context);
                var predicateContext = new PredicateContext(context.GlobalState, context.Position,
                    childApplies: ChildApplies(),
                    applyingItem: appliesAtResult.PositiveLog.ContainsAssignableTo<Item>(),
                    applyingTail: appliesAtResult.PositiveLog.ContainsTail(),
                    applyingLiteral: appliesAtResult.PositiveLog.ContainsAssignableTo<Literal>(),
                    applyingParent: appliesAtContext.IsParent,
                    applyingOr: appliesAtResult.PositiveLog.Contains<Or>(),
                    applyingStart: appliesAtResult.PositiveLog.Contains<Start>(),
                    applyingSpawn: context.Spawner != null,
                    allowNewLine: !children.Any());
                if (predicate.AppliesAt(predicateContext))
                {
                    WritePreviousUntilSubjectOnce();
                    WriteSubjectlessSkippedUntilEnd();
                    var toStringResult = predicate.ToString(predicateContext);
                    var writeAs = context.WriteAsScope.GetWriteAs(context, appliesAtResult);
                    context.Write(toStringResult.Result, writeAs, toStringResult.Rewind, toStringResult.SeekBy);
                }
            }
            ApplyChildren(appliedSentence: apply);
            if (context.Style.MoveNext())
                context.Style.Current.Apply(NextContext(appliesAtResult));
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
            var notWrittenOrIsSpawn = !context.Written(this) || context.Spawner != null;
            if (!HasSubject && notWrittenOrIsSpawn)
                context.Write(predicate.ToString(new PredicateContext(context.GlobalState)).Result, this, false, 0);
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

        PositionStep[] StartPosition()
        {
            if (context.ParentScope.IsParent(this))
                return context.ParentScope.StartedAt;
            else
                if (context.SpawnerPosition == null)
                    return null;
                else
                {
                    var spawnerPosition = context.SpawnerPosition;
                    if (spawnerPosition.LastTokenType().IsEnd())
                        spawnerPosition = spawnerPosition.ExceptLast().ToArray();
                    return spawnerPosition;
                }
        }

        bool FindParent(AppliesAtContext appliesAtContext)
        {
            if (HasSubject && subject.HasParent() && !appliesAtContext.IsParent)
            {
                context.ReducedsScope.Change(context);
                var reduced = context.ReducedsScope.GetReduced();
                if (reduced == null)
                    reduced = subject;
                reduced = reduced.ReduceAt(appliesAtContext.Copy(findParent: true));
                context.ReducedsScope.SetReduced(reduced);
                if (reduced.JustAny())
                {
                    Extension.WriteDebug(context.Position.ToDebugString());
                    Extension.WriteDebugLine("[ParentFound]");
                    context.ParentScope.ParentFound(this);
                    return true;
                }
            }
            return false;
        }

        bool SkipStrictCopyBecauseSpawnerCopiedIt()
        {
            var isStrictCopy = context.Strict && predicate.HasOuterId() && predicate.HasOuterValue();
            return isStrictCopy && context.SpawnerCanCopy;
        }

        bool ChildApplies()
        {
            if (children.Any())
            {
                var afterChildren = new MarkerSentence();
                var childrenAndAfterChildren = children.Concat(afterChildren.Enclose());
                var childrenStyle = childrenAndAfterChildren.Cast<Sentence>().GetEnumerator();
                var childrenContext = context.Copy(caller: this, style: childrenStyle,
                    spawnerPosition: context.SentenceScope.StartsAt(), scan: true, spawnerCanCopy: CanCopyAsSpawner(),
                    spawner: this);
                childrenStyle.MoveNext();
                childrenStyle.Current.Apply(childrenContext);
                if (afterChildren.Reached)
                    return false;
                else
                {
                    Extension.WriteDebugLine("[ChildApplies]");
                    return true;
                }
            }
            else
                return false;
        }

        void ApplyChildren(bool appliedSentence)
        {
            if (children.Any() && context.SentenceScope.EndsAt(context, appliedSentence: appliedSentence))
            {
                Extension.WriteDebugLine("[ApplyChildren]");
                context.Spawn(EnsureThatEachChildWithValueHasSubject(), this, CanCopyAsSpawner());
                Extension.WriteDebugLine("[/ApplyChildren]");
                if (context.GlobalState.WriteDeferredNewLine)
                {
                    context.Write(Environment.NewLine, context.Style.Current, true, 0);
                    context.GlobalState.WriteDeferredNewLine = false;
                }
            }
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

        ApplyContext NextContext(AppliesAtResult appliesAtResult)
        {
            if (appliesAtResult.Result)
            {
                bool strict;
                if (context.Scan && predicate.HasOuterId() && predicate.HasOuterValue() && context.SpawnerCanCopy)
                    strict = !context.Strict;
                else
                    strict = true;
                return context.Copy(caller: this, strict: strict);
            }
            else
                return context.Copy(this);
        }

        IEnumerable<Sentence> PreviousUntilSubjectReversed()
        {
            foreach (var sentence in context.Previous.Reverse())
                if (sentence.HasSubject)
                    break;
                else
                    yield return sentence;
        }

        bool CanCopyAsSpawner()
        {
            return predicate.HasOuterId() && predicate.HasValue();
        }

        Sentence[] EnsureThatEachChildWithValueHasSubject()
        {
            var replacement = children
                .Select(child => child.predicate.HasValue() && !child.HasSubject
                    ? new Sentence(subject, child.predicate, child.children)
                    : child)
                .ToArray();
            return replacement;
        }

        bool HasSubject { get { return subject != null; } }
    }
}
