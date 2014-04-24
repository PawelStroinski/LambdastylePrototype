using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input5.json._5_render_as_ASCII_context_menu_2
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new ShortOr(
                    new Path(new NotEquals(new Path(new Id("items"), new Item()), new Null()), new Id("label")),
                    new Path(new NotEquals(new Path(new Id("items"), new Item()), new Null()), new Id("id")))),
                    new Predicate(new Raw("["), new InnerValue(), new Raw("]"))),
                new Sentence(new Subject(new Equals(new Path(new Id("items"), new Item()), new Null())),
                    new Predicate("----------")));
        }
    }
}
