using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace CLI
{
    class Options
    {
        [Option('i', "input", Required = true, HelpText = "JSON input file to read.")]
        public string InputPath { get; set; }

        [Option('s', "style", Required = true, HelpText = "Lambdastyle file to apply.")]
        public string StylePath { get; set; }

        [Option('o', "output", Required = true, HelpText = "Output file to write.")]
        public string OutputPath { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this).ToString();
        }
    }
}
