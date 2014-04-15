using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input5.json._5_append_dots_to_every_label_not_ending_with_dots
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new NotEquals(new Id("label"),
                        new LiteralishSequence(new Any(), new Literal("...")))),
                    new Predicate(new OuterId(), new Raw("\""), new InnerValue(), new Raw("...\""))),
                Consts.CopyAny);
        }
    }
}
