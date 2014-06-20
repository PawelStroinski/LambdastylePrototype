using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype;

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
            catch (Exception exception)
            {
                PrintException(exception);
            }
        }

        static void CarefreeMain(string[] args)
        {
            var opt = new Options();
            var facade = new Facade();
            if (CommandLine.Parser.Default.ParseArguments(args, opt))
                facade.ProcessFile(inputPath: opt.InputPath, stylePath: opt.StylePath, outputPath: opt.OutputPath);
        }

        static void PrintException(Exception exception)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            try
            {
                Console.Write(exception);
            }
            finally
            {
                Console.ForegroundColor = color;
            }
        }
    }
}
