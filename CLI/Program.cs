using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;
using StreamUtils;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarefreeMain(args);
            }
            catch (LambdastylePrototype.Parser.ParserException exception)
            {
                PrintException("Error in style file:", exception, stackTrace: false);
            }
            catch (Newtonsoft.Json.JsonException exception)
            {
                PrintException("Error in input JSON file:", exception, stackTrace: false);
            }
            catch (IOException exception)
            {
                PrintException("Error:", exception, stackTrace: false);
            }
            catch (Exception exception)
            {
                PrintException("Error:", exception, stackTrace: true);
            }
        }

        static void CarefreeMain(string[] args)
        {
            var options = new Options();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                var facade = new Facade();
                using (var input = new FileStream(options.InputPath, FileMode.Open, FileAccess.Read))
                using (var style = new FileStream(options.StylePath, FileMode.Open, FileAccess.Read))
                using (var output = new EditableFileStream(options.OutputPath, FileMode.Create))
                    facade.Execute(input, style, output);
            }
        }

        static void PrintException(string header, Exception exception, bool stackTrace)
        {
            const int maxStackTraceLength = 700;
            var color = Console.ForegroundColor;
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine(header);
                Console.WriteLine(exception.Message);
                if (stackTrace)
                {
                    Console.WriteLine();
                    if (exception.StackTrace.Length > maxStackTraceLength)
                        Console.WriteLine(exception.StackTrace.Substring(0, maxStackTraceLength) + "...");
                    else
                        Console.WriteLine(exception.StackTrace);
                }
                Console.WriteLine();
            }
            finally
            {
                Console.ForegroundColor = color;
            }
        }
    }
}
