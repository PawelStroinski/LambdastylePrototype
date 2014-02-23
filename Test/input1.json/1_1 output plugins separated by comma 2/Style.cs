using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input1.json._1_1_output_plugins_separated_by_comma_2
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Path(new Id("plugins"), new Item())),
                    new Predicate(new Raw("("), new InnerValue(), new Raw("), "))));
        }
    }
}
