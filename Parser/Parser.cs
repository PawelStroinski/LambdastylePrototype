using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using LambdastylePrototype.Interpreter;

namespace LambdastylePrototype.Parser
{
    class Parser
    {
        public Sentence[] Parse(Stream style)
        {
            var styleReturn = ParseWithANTLR(style);
            var tree = (CommonTree)styleReturn.Tree;
            var builder = new Builder();
            var walker = new Walker(builder);
            walker.Walk(tree);
            return builder.GetStyle();
        }

        LambdastyleTryParser.style_return ParseWithANTLR(Stream input)
        {
            var stream = new ANTLRInputStream(input);
            var lexer = new LambdastyleTryLexer(stream);
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new LambdastyleTryParser(tokenStream);
            var trace = new StringWriter();
            parser.TraceDestination = trace;
            var parsed = parser.style();
            ThrowTrace(trace);
            return parsed;
        }

        static void ThrowTrace(StringWriter trace)
        {
            var message = trace.ToString();
            if (!string.IsNullOrEmpty(message))
                throw new ParserException(message.Trim());
        }
    }
}
