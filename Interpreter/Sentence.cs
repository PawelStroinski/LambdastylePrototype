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

        public void Apply(ApplyContext context)
        {
            this.context = context;
            if (HasSubject && subject.AppliesAt(context.Position, strict: true))
            {
                Console.WriteLine(context.Position.ToString(true));
                if (predicate.AppliesAt(context.Position))
                {
                    WritePreviousUntilSubjectOnce();
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
            if (subject != null && subject.JustAny() && predicate.HasOuterValue())
                context.GlobalState.ForceSyntax = false;
            if (context.Style.MoveNext())
                context.Style.Current.ApplyBOF(context);
            else
                if (!context.GlobalState.ForceSyntax.HasValue)
                    context.GlobalState.ForceSyntax = false;
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
            foreach (var sentence in previousNotWritten)
                context.Write(sentence.predicate.ToString(new ToStringContext(context.GlobalState)), sentence, true);
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
