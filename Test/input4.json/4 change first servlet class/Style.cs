using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input4.json._4_change_first_servlet_class
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Path(new Id("servlet"), new ItemIndex(0), new Id("servlet-class"))),
                    new Predicate(new OuterId(), new Raw("\"new class\""))),
                Consts.CopyAny);
        }
    }
}
