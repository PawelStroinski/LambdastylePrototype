using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StreamUtils;

namespace LambdastylePrototype
{
    public interface IFacade
    {
        string ProcessString(string input, string style);
        void ProcessFile(string inputPath, string stylePath, string outputPath);
        void ProcessStream(Stream input, Stream style, EditableStream output);
    }
}
