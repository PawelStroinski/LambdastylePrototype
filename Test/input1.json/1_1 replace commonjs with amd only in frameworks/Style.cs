using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input1.json._1_1_replace_commonjs_with_amd_only_in_frameworks
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Equals(new Path(new Id("frameworks"), new Item()),
                        new Literal("commonjs"))),
                    new Predicate(new OuterId(), new Raw("\"amd\""))),
                Consts.CopyAny);
        }
    }
}
