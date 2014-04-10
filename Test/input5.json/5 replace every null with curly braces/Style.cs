using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input5.json._5_replace_every_null_with_curly_braces
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Equals(new Any(), new Null())),
                    new Predicate(new OuterId(), new Raw("{}"))),
                Consts.CopyAny);
        }
    }
}
