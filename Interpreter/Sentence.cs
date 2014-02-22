﻿using System;
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

        public void Apply(ApplyContext context)
        {
            this.context = context;
            var appliesAtContext = new AppliesAtContext(context.Position, strict: true);
            var appliesAt = HasSubject && subject.AppliesAt(appliesAtContext);
            var isParent = context.ParentScope.IsParent(this);
            if (appliesAt || isParent)
            {
                Extension.WriteLine(context.Position.ToString(true));
                if (!isParent && subject.AppliesAt(appliesAtContext.CopyAsInParentOnly()))
                {
                    context.ParentScope.ParentFound(this);
                    return;
                }
                if (predicate.AppliesAt(context.Position))
                {
                    WritePreviousUntilSubjectOnce();
                    WriteSubjectlessSkippedUntilEnd();
                    var toStringContext = new ToStringContext(context.Position, context.GlobalState);
                    context.Write(predicate.ToString(toStringContext), this, !subject.JustAny());
                }
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
                context.Write(predicate.ToString(new ToStringContext(context.GlobalState)), this, true);
            if (context.Style.MoveNext())
                context.Style.Current.ApplyEOF(context);
            else
                if (context.GlobalState.InsertedStartToken.HasValue)
                {
                    var endToken = context.GlobalState.InsertedStartToken == JsonToken.StartObject ? "}" : "]";
                    context.Write(" " + endToken, this, true);
                }
                else
                    if (context.Position.Last().DelimitersAfter != string.Empty)
                        context.Write(context.Position.Last().DelimitersAfter, this, true);
        }

        void WritePreviousUntilSubjectOnce()
        {
            var previous = PreviousUntilSubjectReversed().Reverse().ToArray();
            var previousNotWritten = previous.Where(sentence => !context.Written(sentence)).ToArray();
            var toWrite = previousNotWritten.Except(context.GlobalState.SubjectlessSkippedUntilEnd);
            foreach (var sentence in toWrite)
                context.Write(sentence.predicate.ToString(new ToStringContext(context.GlobalState)), sentence, true);
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
                var value = delimitersBefore
                    + sentence.predicate.ToString(new ToStringContext(context.GlobalState, allowNewLine: false));
                context.Write(value, sentence, true);
                context.GlobalState.WrittenInThisObject = true;
            }
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
