using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input1.json._1_1_add_key_at_the_end_of_file
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Predicate("\"key\": \"value\"")),
                Consts.CopyAny);
        }
    }
}
