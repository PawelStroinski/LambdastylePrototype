using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input3.json._3_copy_title_from_window_to_image
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Id("image")),
                    new Predicate(new OuterId(), new Raw("{"), new InnerValue()),
                    new Sentence(new Subject(new Path(new Id("window"), new Id("title"))),
                        new Predicate(new OuterId(), new OuterValue(), new Raw("}")))),
                Consts.CopyAny);
        }
    }
}
