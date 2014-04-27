using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input5.json._5_copy_every_label_as_description
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Id("label")),
                    new Predicate(new Raw("\"description\": "), new OuterValue())),
                new Sentence(new Subject(new Id("label")), Consts.Copy),
                Consts.CopyAny);
        }
    }
}
