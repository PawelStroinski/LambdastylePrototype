using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter.Subjects;

namespace LambdastylePrototype
{
    class SubjectScratchpad
    {
        SubjectScratchpad()
        {
            // "singleRun"
            new Subject(new Id("singeRun"));
            // item="commonjs"
            new Subject(new Equals(new Item(), new Literal("commonjs")));
            // "frameworks".item="commonjs"
            new Subject(new Equals(new Path(new Id("frameworks"), new Item()), new Literal("commonjs")));
            // [item="commonjs"]
            new Subject(new Parent(new Equals(new Item(), new Literal("commonjs"))));
            // "plugins".item
            new Subject(new Path(new Id("plugins"), new Item()));
            // "reporters"&"plugins"
            new Subject(new And(new Id("reporters"), new Id("plugins")));
            // *=500
            new Subject(new Equals(new Any(), new Literal(500)));
            // item
            new Subject(new Item());
            // "value"="Open"
            new Subject(new Equals(new Id("value"), new Literal("Open")));
            // "menu"."value"
            new Subject(new Path(new Id("menu"), new Id("value")));
            // "menuitem".item."value"
            new Subject(new Path(new Id("menuitem"), new Item(), new Id("value")));
            // .*
            new Subject(new Path(new Start(), new Any()));
            // ["name"!="text1"]."alignment"
            new Subject(new Path(new Parent(new Not(new Equals(new Id("name"), new Literal("text1")))), new Id("alignment")));
            // "servlet".item[0]
            new Subject(new Path(new Id("servlet"), new ItemIndex(0)));
            // "servlet".item[0]."servlet-class"
            new Subject(new Path(new Id("servlet"), new ItemIndex(0), new Id("servlet-class")));
            // ["servlet-name"="cofaxTools"]."init-param"
            new Subject(new Path(new Parent(new Equals(new Id("servlet-name"), new Literal("cofaxTools"))), new Id("init-param")));
            // *=*"&id="
            new Subject(new Equals(new Any(), new LiteralishSequence(new Any(), new Literal("&id="))));
            // *=null
            new Subject(new Equals(new Any(), new Null()));
            // ["id"&!"label"]
            new Subject(new Parent(new And(new Id("id"), new Not(new Id("label")))));
            // "label"!=*"..."
            new Subject(new Not(new Equals(new Id("label"), new LiteralishSequence(new Any(), new Literal("...")))));
            // "items".item!=null
            new Subject(new Not(new Equals(new Path(new Id("items"), new Item()), new Null())));
            // ."id"
            new Subject(new Path(new Start(), new Id("id")));
            // ."label"|."id"
            new Subject(new Or(new Path(new Start(), new Id("label")), new Path(new Start(), new Id("id"))));
            // *=/[A-Z]{2}/
            new Subject(new Equals(new Any(), new RegExp("[A-Z]{2}")));
        }
    }
}
