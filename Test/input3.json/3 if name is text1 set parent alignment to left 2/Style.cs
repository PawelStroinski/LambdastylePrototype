using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input3.json._3_if_name_is_text1_set_parent_alignment_to_left_2
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Parent(new Equals(new Id("name"), new Literal("text1")))),
                    new Predicate(new OuterId(), new Raw("{")),
                    new Sentence(new Subject(new Path(new Start(), new Id("alignment"))),
                        new Predicate(new OuterId(), new Raw("\"left\""))),
                    new Sentence(new Subject(new Path(new Start(), new Any())), Consts.Copy),
                    new Sentence(new Predicate("}"))),
                Consts.CopyAny);
        }
    }
}
