using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input5.json._5_similar_to_if_id_is_present_but_not_label_copy_it_as_label
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Parent(new And(new Id("id"), new Not(new Id("label"))))),
                    new Predicate(new OuterId(), new Raw("{"), new InnerValue()),
                    new Sentence(new Subject(new Path(new Start(), new Id("id"))),
                        new Predicate(new Raw("\"label\": "), new OuterValue(), new Raw("}"))),
                    new Sentence(new Subject(new Path(new Start(), new Id("id"))), new Predicate(new Raw("   ")))),
                Consts.CopyAny);
        }
    }
}
