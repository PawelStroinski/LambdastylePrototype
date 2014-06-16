using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using StreamUtils;

namespace LambdastylePrototype
{
    public class Facade
    {
        public string Execute(string input, string style)
        {
            using (var inputSteam = new MemoryStream(Encoding.UTF8.GetBytes(input)))
            using (var styleStream = new MemoryStream(Encoding.UTF8.GetBytes(style)))
            using (var output = new EditableMemoryStream())
            {
                Execute(inputSteam, styleStream, output);
                output.Position = 0;
                using (var outputReader = new StreamReader(output))
                    return outputReader.ReadToEnd();
            }
        }

        public void Execute(Stream input, Stream style, EditableStream output)
        {
            var parser = new Parser.Parser();
            var parsedStyle = parser.Parse(style);
            var processor = new Processor(input, output, parsedStyle);
            processor.Process();
        }
    }
}
