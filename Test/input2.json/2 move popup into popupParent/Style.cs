using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input2.json._2_move_popup_into_popupParent
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Id("popup")),
                    new Predicate(new Raw("\"popupParent\": {"), new OuterId(), new OuterValue(), new Raw("}"))),
                Consts.CopyAny);
        }
    }
}
