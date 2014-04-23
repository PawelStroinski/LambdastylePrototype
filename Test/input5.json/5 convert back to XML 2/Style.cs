using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input5.json._5_convert_back_to_XML_2
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Predicate("<menu>")),
                new Sentence(new Subject(new Id("header")),
                    new Predicate(new Raw("  <header>"), new InnerValue(), new Raw("</header>"))),
                new Sentence(new Subject(new NotEquals(new Path(new Id("items"), new Item()), new Null())),
                    new Predicate("  <item "),
                    new Sentence(new Subject(new Path(new Start(), new Id("id"))),
                        new Predicate(new Raw("action=\""), new InnerValue(),
                            new Raw("\" id=\""), new InnerValue(), new Raw("\">"))),
                    new Sentence(new Subject(new Path(new Start(), new Id("label"))),
                        new Predicate(new InnerValue(), new Raw("</item>"))),
                    new Sentence(new Subject(new Path(new Parent(new And(new Path(new Start(), new Id("id")),
                            new Not(new Path(new Start(), new Id("label"))))), new Id("id"))),
                        new Predicate(new InnerValue(), new Raw("</item>")))),
                new Sentence(new Subject(new Equals(new Path(new Id("items"), new Item()), new Null())),
                    new Predicate("  <separator/>")),
                new Sentence(new Predicate("</menu>")));
        }
    }
}
