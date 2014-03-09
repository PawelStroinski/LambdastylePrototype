using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input2.json._2_replace_Open_menu_item_with_Export_2
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Id("value")),
                    new Predicate(new OuterId(), new Raw("\"Export\""))),
                new Sentence(new Subject(new Id("onclick")),
                    new Predicate(new OuterId(), new Raw("\"ExportDoc()\""))),
                Consts.CopyAny);
        }
    }
}
