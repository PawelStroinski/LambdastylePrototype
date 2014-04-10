using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input4.json._4_copy_params_from_cofaxEmail_to_cofaxTools
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Path(new Parent(
                    new Equals(new Id("servlet-name"), new Literal("cofaxTools"))), new Id("init-param"))),
                    new Predicate(new OuterId(), new Raw("{"), new InnerValue()),
                    new Sentence(new Subject(new Path(new Parent(
                        new Equals(new Id("servlet-name"), new Literal("cofaxEmail"))), new Id("init-param"))),
                        new Predicate(new InnerValue(), new Raw("}")))),
                Consts.CopyAny);
        }
    }
}
