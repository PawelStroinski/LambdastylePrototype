using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input4.json._4_remove_every_key_with_value_ending_with_id
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Equals(new Any(), new LiteralishSequence(new Any(), new Literal("&id=")))),
                    new Predicate()),
                Consts.CopyAny);
        }
    }
}
