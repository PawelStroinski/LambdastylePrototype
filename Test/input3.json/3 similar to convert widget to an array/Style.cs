using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input3.json._3_similar_to_convert_widget_to_an_array
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Id("widget")), new Predicate(new OuterId(), new Raw("[]"))),
                Consts.CopyAny);
        }
    }
}
