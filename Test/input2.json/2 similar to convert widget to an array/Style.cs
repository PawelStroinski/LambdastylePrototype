using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input2.json._2_similar_to_convert_widget_to_an_array
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Id("menuitem")), new Predicate(new OuterId(), new Raw("[")),
                    new Sentence(new Subject(new Path(new Start(), new Any())),
                        new Predicate(new OuterValue())),
                    new Sentence(new Predicate(new Raw("]")))),
                Consts.CopyAny);
        }
    }
}
