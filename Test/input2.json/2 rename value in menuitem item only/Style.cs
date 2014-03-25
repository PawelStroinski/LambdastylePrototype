using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input2.json._2_rename_value_in_menuitem_item_only
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Path(new Id("menuitem"), new Item(), new Id("value"))),
                    new Predicate(new Raw("\"value2\": "), new OuterValue())),
                Consts.CopyAny);
        }
    }
}
