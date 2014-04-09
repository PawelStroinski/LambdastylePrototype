using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input4.json._4_swap_first_and_second_servlet
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Path(new Id("servlet"), new ItemIndex(0))), new Predicate(),
                    new Sentence(new Subject(new Path(new Id("servlet"), new ItemIndex(1))),
                        new Predicate(new OuterValue()))),
                new Sentence(new Subject(new Path(new Id("servlet"), new ItemIndex(1))), new Predicate(),
                    new Sentence(new Subject(new Path(new Id("servlet"), new ItemIndex(0))),
                        new Predicate(new OuterValue()))),
                Consts.CopyAny);
        }
    }
}
