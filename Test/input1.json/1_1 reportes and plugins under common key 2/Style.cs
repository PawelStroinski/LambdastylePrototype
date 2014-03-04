using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input1.json._1_1_reportes_and_plugins_under_common_key_2
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Or(new Id("files"), new Id("reporters"), new Id("plugins"))),
                    new Predicate(new Raw("\"filesAndReportersAndPlugins\": "), new OuterValue())),
                Consts.CopyAny);
        }
    }
}
