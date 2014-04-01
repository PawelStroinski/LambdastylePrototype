using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input2.json._2_move_popup_as_menu_sibling_2
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Parent(new Id("menu"))),
                    new Predicate(new OuterId(), new Raw("{"), new InnerValue()),
                    new Sentence(new Subject(new Id("popup")), Consts.Copy),
                    new Sentence(new Predicate("}"))));
        }
    }
}
