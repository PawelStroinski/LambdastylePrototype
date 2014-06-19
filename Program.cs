using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;
using Newtonsoft.Json;
using StreamUtils;

namespace LambdastylePrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputPath = @"C:\nodejs\jsonslt\input1.json";
            var outputPath = @"T:\output.txt";
            var input = new System.IO.FileStream(inputPath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            var output = new EditableFileStream(outputPath, System.IO.FileMode.Create);
            var processor = new Processor(input, output,
                new Sentence(new Predicate("<config>")),
                new Sentence(new Predicate("  <plugins>")),
                new Sentence(new Subject(new Path(new Id("plugins"), new Item())),
                    new Predicate(new Raw("    <item>"), new InnerValue(), new Raw("</item>"))),
                new Sentence(new Predicate("  </plugins>")),
                new Sentence(new Subject(new Id("basePath")),
                    new Predicate(new Raw("  <basePath>"), new InnerValue(), new Raw("</basePath>"))),
                new Sentence(new Predicate("</config>"))/*,
                new Sentence(new Subject(new Any()), new Predicate())*/);
            processor.Process();
            input.Close();
            output.Close();
        }
    }
}
