using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input3.json._3_swap_offsets_in_text
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Path(new Id("text"), new Id("hOffset"))), new Predicate(new OuterId()),
                    new Sentence(new Subject(new Path(new Id("text"), new Id("vOffset"))),
                        new Predicate(new OuterValue()))),
                new Sentence(new Subject(new Path(new Id("text"), new Id("vOffset"))), new Predicate(new OuterId()),
                    new Sentence(new Subject(new Path(new Id("text"), new Id("hOffset"))),
                        new Predicate(new OuterValue()))),
                Consts.CopyAny);
        }
    }
}
