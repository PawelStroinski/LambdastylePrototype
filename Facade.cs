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
        public string ProcessString(string input, string style)
        {
            var outputAsString = string.Empty;
            CatchExceptions(() =>
            {
                using (var inputSteam = new MemoryStream(Encoding.UTF8.GetBytes(input)))
                using (var styleStream = new MemoryStream(Encoding.UTF8.GetBytes(style)))
                using (var output = new EditableMemoryStream())
                {
                    CarefreeProcessStream(input: inputSteam, style: styleStream, output: output);
                    output.Position = 0;
                    using (var outputReader = new StreamReader(output))
                        outputAsString = outputReader.ReadToEnd();
                }
            });
            return outputAsString;
        }

        public void ProcessFile(string inputPath, string stylePath, string outputPath)
        {
            CatchExceptions(() =>
            {
                using (var input = new FileStream(inputPath, FileMode.Open, FileAccess.Read))
                using (var style = new FileStream(stylePath, FileMode.Open, FileAccess.Read))
                using (var output = new EditableFileStream(outputPath, FileMode.Create))
                    CarefreeProcessStream(input: input, style: style, output: output);
            });
        }

        public void ProcessStream(Stream input, Stream style, EditableStream output)
        {
            CatchExceptions(() =>
            {
                CarefreeProcessStream(input: input, style: style, output: output);
            });
        }

        void CarefreeProcessStream(Stream input, Stream style, EditableStream output)
        {
            var parser = new Parser.Parser();
            var parsedStyle = parser.Parse(style);
            var processor = new Processor(input, output, parsedStyle);
            processor.Process();
        }

        void CatchExceptions(Action action)
        {
            try
            {
                action();
            }
            catch (LambdastylePrototype.Parser.ParserException exception)
            {
                throw new ParserFacadeException(exception);
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                throw new InputFacadeException(exception);
            }
            catch (IOException exception)
            {
                throw new SystemIOFacadeException(exception);
            }
            catch (Exception exception)
            {
                throw new OtherFacadeException(exception);
            }
        }
    }
}
