using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input5.json._5_move_Mute_item_before_About_item
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Parent(new Equals(new Id("id"), new Literal("About")))), new Predicate(),
                    new Sentence(new Subject(new Parent(new Equals(new Id("id"), new Literal("Mute")))),
                        new Predicate(new OuterValue())),
                    new Sentence(new Predicate(new OuterValue()))),
                new Sentence(new Subject(new Parent(new Equals(new Id("id"), new Literal("Mute")))), new Predicate()),
                Consts.CopyAny);
        }
    }
}
