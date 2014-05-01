using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace LambdastylePrototype
{
    class SentenceScratchpad
    {
        SentenceScratchpad()
        {
            // "singleRun" -> #true
            new Sentence(new Subject(new Id("singleRun")), new Predicate(new OuterId(), new Raw("true")));
            // item="commonjs" ->
            new Sentence(new Subject(new Equals(new Item(), new Literal("commonjs"))), new Predicate());
            // "frameworks".item="commonjs" -> #"amd"
            new Sentence(new Subject(new Equals(new Path(new Id("frameworks"), new Item()), new Literal("commonjs"))),
                new Predicate(new OuterId(), new Raw("\"amd\"")));
            // "key": "value"
            new Sentence(new Predicate("\"key\": \"value\""));
            //"plugins" -> #&
            //* ->
            new Sentence(new Subject(new Id("plugins")), new Predicate(new OuterId(), new OuterValue()));
            new Sentence(new Subject(new Any()), new Predicate());
            //"plugins" -> &
            new Sentence(new Subject(new Id("plugins")), new Predicate(new OuterValue()));
            // "plugins".item -> |,
            new Sentence(new Subject(new Path(new Id("plugins"), new Item())),
                new Predicate(new InnerValue(), new Raw(", ")));
            //Reporters:
            //"reporters".item -> |
            //
            //Plugins:
            //"plugins".item -> |
            new Sentence(new Predicate("Reporters:"));
            new Sentence(new Subject(new Path(new Id("reporters"), new Item())), new Predicate(new InnerValue()));
            new Sentence(new Predicate());
            new Sentence(new Predicate("Plugins:"));
            new Sentence(new Subject(new Path(new Id("plugins"), new Item())), new Predicate(new InnerValue()));
            // "reporters" -> #[|, "custom"]
            new Sentence(new Subject(new Id("reporters")),
                new Predicate(new OuterId(), new Raw("["), new InnerValue(), new Raw(", \"custom\"]")));
            // item -> [&]
            new Sentence(new Subject(new Item()),
                new Predicate(new Raw("["), new OuterValue(), new Raw("]")));
            //<config>
            //  <plugins>
            //    "plugins".item -> <item>|</item>
            //  </plugins>
            //  <basePath>"basePath" -> |</basePath>
            //</config>
            new Sentence(new Predicate("<config>"));
            new Sentence(new Predicate("  <plugins>"));
            new Sentence(new Subject(new Path(new Id("plugins"), new Item())),
                new Predicate(new Raw("    <item>"), new InnerValue(), new Raw("</item>")));
            new Sentence(new Predicate("  </plugins>"));
            new Sentence(new Subject(new Id("basePath")),
                new Predicate(new Raw("  <basePath>"), new InnerValue(), new Raw("</basePath>")));
            new Sentence(new Predicate("</config>"));
            //"menuitem" -> #[|, {
            //    "value": "Export",
            //    "onclick": "ExportDoc()"
            //  }]
            new Sentence(new Subject(new Id("menuitem")), new Predicate(new OuterId(), new Raw("["), new InnerValue(),
                new Raw(", {\n  \"value\": \"Export\",\n  \"onclick\": \"ExportDoc()\"\n}]")));
            // "popup" -> "popupParent": {#&}
            new Sentence(new Subject(new Id("popup")),
                new Predicate(new Raw("\"popupParent\": {"), new OuterId(), new OuterValue(), new Raw("}")));
            //["menu"] -> #{|,
            //  "popup" -> #&}
            new Sentence(new Subject(new Parent(new Id("menu"))),
                new Predicate(new OuterId(), new Raw("{"), new InnerValue(), new Raw(",")),
                new Sentence(new Subject(new Id("popup")), new Predicate(new OuterId(), new OuterValue(), new Raw("}"))));
            //"text"."hOffset" -> #
            //  "text"."vOffset" -> &
            //"text"."vOffset" -> #
            //  "text"."hOffset" -> &
            new Sentence(new Subject(new Path(new Id("text"), new Id("hOffset"))), new Predicate(new OuterId()),
                new Sentence(new Subject(new Path(new Id("text"), new Id("vOffset"))), new Predicate(new OuterValue())));
            new Sentence(new Subject(new Path(new Id("text"), new Id("vOffset"))), new Predicate(new OuterId()),
                new Sentence(new Subject(new Path(new Id("text"), new Id("hOffset"))), new Predicate(new OuterValue())));
            // "image" -> #&, "image2": &
            new Sentence(new Subject(new Id("image")),
                new Predicate(new OuterId(), new OuterValue(), new Raw(", \"image2\": "), new OuterValue()));
            //"widget" -> #[
            //  .* -> {#&},
            //  ]
            new Sentence(new Subject(new Id("widget")), new Predicate(new OuterId(), new Raw("[")),
                new Sentence(new Subject(new Path(new Start(), new Any())),
                    new Predicate(new Raw("{"), new OuterId(), new OuterValue(), new Raw("},"))),
                new Sentence(new Predicate("]")));
            //"debug"="on" ->
            //  * -> #&
            new Sentence(new Subject(new Equals(new Id("debug"), new Literal("on"))), new Predicate(),
                new Sentence(new Subject(new Any()), new Predicate(new OuterId(), new OuterValue())));
            //["id"&!"label"] -> #&,
            //  "label": "id" -> &
            new Sentence(new Subject(new Parent(new And(new Id("id"), new Not(new Id("label"))))),
                new Predicate(new OuterId(), new OuterValue(), new Raw(",")),
                new Sentence(new Subject(new Id("id")), new Predicate(new Raw("\"label\": "), new OuterValue())));
            // "label"!=*"..." -> #"|..."
            new Sentence(new Subject(new Not(new Equals(new Id("label"),
                    new LiteralishSequence(new Any(), new Literal("..."))))),
                new Predicate(new OuterId(), new Raw("\""), new InnerValue(), new Raw("...\"")));
            //<menu>
            //  <header>"header" -> |</header>
            //  "items".item!=null -> <item 
            //    ."id" -> action="|" id="|">
            //    ."label"|."id" -> |</item>
            //  "items".item=null -> <separator/>
            //</menu>
            new Sentence(new Predicate("<menu>"));
            new Sentence(new Subject(new Id("header")),
                new Predicate(new Raw("  <header>"), new InnerValue(), new Raw("</header>")));
            new Sentence(new Subject(new Not(new Equals(new Path(new Id("items"), new Item()), new Null()))),
                new Predicate("  <item "),
                new Sentence(new Subject(new Path(new Start(), new Id("id"))), new Predicate(new Raw("action=\""),
                    new InnerValue(), new Raw("\" id=\""), new InnerValue(), new Raw("\">"))),
                new Sentence(new Subject(new Or(new Path(new Start(), new Id("label")), new Path(new Start(),
                    new Id("id")))), new Predicate(new InnerValue(), new Raw("</item>"))));
            //"items" -> #{
            //  .item ->
            //    ."id" -> &:
            //    &,
            //  }
            new Sentence(new Subject(new Id("items")), new Predicate(new OuterId(), new Raw("{")),
                new Sentence(new Subject(new Path(new Start(), new Item())), new Predicate(),
                    new Sentence(new Subject(new Path(new Start(), new Id("id"))),
                        new Predicate(new OuterValue(), new Raw(":"))),
                    new Sentence(new Predicate(new OuterValue(), new Raw(",")))),
                new Sentence(new Predicate("}")));
            // *=/[A-Z]{2}/ ->
            new Sentence(new Subject(new Equals(new Any(), new RegExp("[A-Z]{2}"))), new Predicate());
            //["id"="About"] ->
            //  ["id"="Mute"] -> &,
            //  &
            new Sentence(new Subject(new Parent(new Equals(new Id("id"), new Literal("About")))), new Predicate(),
                new Sentence(new Subject(new Parent(new Equals(new Id("id"), new Literal("Mute")))),
                    new Predicate(new OuterValue(), new Raw(","))),
                new Sentence(new Predicate(new OuterValue())));
            //"label"=\^(\w*) (\w*)$\ -> #"\1\|\2"
            new Sentence(new Subject(new Equals(new Id("label"), new RegExp("^(\\w*) (\\w*)$"))),
                new Predicate(new OuterId(), new Raw("\""), new RegExpGroup(1), new Raw("|"), new RegExpGroup(2),
                    new Raw("\"")));
        }
    }
}
