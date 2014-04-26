using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input5.json._5_convert_items_to_dictionary_by_id
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(
                    new Subject(new Id("items")),
                    new Predicate(new OuterId(), new Raw("{")),
                        new Sentence(
                            new Subject(new Path(new Start(), new Item())),
                            new Predicate(),
                                new Sentence(
                                    new Subject(new Path(new Start(), new Id("id"))),
                                    new Predicate(new OuterValue(), new Raw(":"))),
                                new Sentence(
                                    new Predicate(new OuterValue()))),
                        new Sentence(
                            new Predicate("}"))),
                Consts.CopyAny);
        }
    }
}
