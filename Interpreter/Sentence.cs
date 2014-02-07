using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter.Subjects;
using LambdastylePrototype.Interpreter.Predicates;

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
                    context.Write(predicate.ToString(context.Position) + Environment.NewLine, this);
                }
            }
            if (context.Style.MoveNext())
                context.Style.Current.Apply(context.Copy(this));
        }

        public void ApplyEOF(ApplyContext context)
        {
            if (!HasSubject && !context.Written(this))
                context.Write(predicate.ToString(context.Position) + Environment.NewLine, this);
            if (context.Style.MoveNext())
                context.Style.Current.ApplyEOF(context);
        }

        void WritePreviousUntilSubjectOnce()
        {
            var previous = PreviousUntilSubjectReversed().Reverse().ToArray();
            var previousNotWritten = previous.Where(sentence => !context.Written(sentence)).ToArray();
            foreach (var sentence in previousNotWritten)
                context.Write(sentence.predicate.ToString(new PositionStep[0]) + Environment.NewLine, sentence);
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
