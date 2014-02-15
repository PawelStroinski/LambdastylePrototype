using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace Test.input1.json._1_2_config
{
    class Style
    {
        void Build(Builder builder)
        {
            builder.Add(
                new Sentence(new Predicate("<config>")),
                new Sentence(new Predicate("  <plugins>")),
                new Sentence(new Subject(new Path(new Id("plugins"), new Item())),
                    new Predicate(new Raw("    <item>"), new InnerValue(), new Raw("</item>"))),
                new Sentence(new Predicate("  </plugins>")),
                new Sentence(new Subject(new Id("basePath")),
                    new Predicate(new Raw("  <basePath>"), new InnerValue(), new Raw("</basePath>"))),
                new Sentence(new Predicate("</config>")));
        }
    }
}
