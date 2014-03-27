using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input2.json._2_similar_to_move_popup_as_menu_sibling_3
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Subject(new Parent(new Id("menuitem"))),
                    new Predicate(new Raw("{"), new InnerValue(), new Raw("}"))));
        }
    }
}
