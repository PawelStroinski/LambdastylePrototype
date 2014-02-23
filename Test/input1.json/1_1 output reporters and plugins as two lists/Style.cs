using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input1.json._1_1_output_reporters_and_plugins_as_two_lists
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Predicate("Reporters:")),
                new Sentence(new Subject(new Path(new Id("reporters"), new Item())),
                    new Predicate(new InnerValue())),
                new Sentence(new Predicate("")),
                new Sentence(new Predicate("Plugins:")),
                new Sentence(new Subject(new Path(new Id("plugins"), new Item())),
                    new Predicate(new InnerValue())));
        }
    }
}
