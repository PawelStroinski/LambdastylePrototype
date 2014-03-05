using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input1.json._1_1_custom_key_and_colors_key
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Predicate("\"custom\": \"key\"")),
                new Sentence(new Subject(new Id("colors")), Consts.Copy));
        }
    }
}
