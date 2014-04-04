using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input3.json._3_copy_image_as_a_widget_sibling
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Parent(new Id("widget"))),
                    new Predicate(new OuterId(), new Raw("{"), new InnerValue()),
                    new Sentence(new Subject(new Id("image")), Consts.Copy),
                    new Sentence(new Predicate("}"))),
                new Sentence(new Subject(new Id("image")), Consts.Copy),
                Consts.CopyAny);
        }
    }
}
