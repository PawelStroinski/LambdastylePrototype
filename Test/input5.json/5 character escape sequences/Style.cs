using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input5.json._5_character_escape_sequences
{
    class Style
    {
        void Build(Builder builder)
        {
            var quote = new Raw("\"").Enclose();
            var common = new PredicateElement[]
            {
                new RegExpGroup(1),
                new Raw("foo"),
                new RegExpGroup(5),
                new Raw("2barf"),
                new Raw("o"),
                new Raw("o"),
                new Raw("|"),
                new Raw("bar"),
                new Raw("&"),
                new Raw("foo"),
                new Raw("#"),
                new Raw("bar"),
                new Raw("\'"),
                new Raw("\""),
                new Raw("\\"),
                new Raw("foo"),
                new Raw("\0"),
                new Raw("\a"),
                new Raw("\b"),
                new Raw("bar"),
                new Raw("\f"),
                new Raw("\n"),
                new Raw("\r"),
                new Raw("foo"),
                new Raw("\t"),
                new Raw("\v"),
            };
            var prefix = new PredicateElement[] {
                new Raw("|"),
                new InnerValue(),
                new OuterId(),
                new Raw("&"),
                new OuterId(),
                new Raw("|"),
                new OuterValue(),
                new Raw("#"),
                new InnerValue()
            };
            builder.Add(
                new Sentence(new Predicate(quote.Concat(common).Concat(quote).ToArray())),
                new Sentence(new Predicate(new Raw("foo"))),
                new Sentence(new Predicate(new InnerValue(), new Raw("bar"))),
                new Sentence(new Predicate(prefix.Concat(common).ToArray())));
        }
    }
}
