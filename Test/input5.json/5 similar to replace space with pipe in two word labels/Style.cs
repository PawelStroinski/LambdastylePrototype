using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input5.json._5_similar_to_replace_space_with_pipe_in_two_word_labels
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Equals(new Id("label"), new LiteralishSequence(new RegExp(@"(\w*) (\w*)"),
                    new RegExp(@" (\w*).*")))), new Predicate(new OuterId(), new Raw("\""), new RegExpGroup(0),
                        new Raw("|"), new RegExpGroup(1), new Raw("|"), new RegExpGroup(2), new Raw("|"),
                        new RegExpGroup(3), new Raw("|"), new RegExpGroup(4), new Raw("\""))),
                Consts.CopyAny);
        }
    }
}
