using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input2.json._2_add_Export_menu_item
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Id("menuitem")),
                    new Predicate(new OuterId(), new Raw("["), new InnerValue(), new Raw(", {"
                        + "\r\n          \"value\": \"Export\","
                        + "\r\n          \"onclick\": \"ExportDoc()\""
                        + "\r\n        }]"))),
                Consts.CopyAny);
        }
    }
}
