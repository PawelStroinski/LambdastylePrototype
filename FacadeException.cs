using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype
{
    public abstract class FacadeException : Exception
    {
        const int maxStackTraceLength = 700;
        bool stackTrace;

        public FacadeException(string message, Exception innerException, bool stackTrace)
            : base(message, innerException) { this.stackTrace = stackTrace; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(Message);
            builder.AppendLine(InnerException.Message);
            if (stackTrace && InnerException.StackTrace != null)
            {
                builder.AppendLine();
                if (InnerException.StackTrace.Length > maxStackTraceLength)
                    builder.AppendLine(InnerException.StackTrace.Substring(0, maxStackTraceLength) + "...");
                else
                    builder.AppendLine(InnerException.StackTrace);
            }
            return builder.ToString();
        }
    }

    public class ParserFacadeException : FacadeException
    {
        public ParserFacadeException(Parser.ParserException innerException)
            : base("Error in style file.", innerException, stackTrace: false) { }
    }

    public class InputFacadeException : FacadeException
    {
        public InputFacadeException(Newtonsoft.Json.JsonException innerException)
            : base("Error in input JSON file.", innerException, stackTrace: false) { }
    }

    public class SystemIOFacadeException : FacadeException
    {
        public SystemIOFacadeException(IOException innerException)
            : base("Error.", innerException, stackTrace: false) { }
    }

    public class OtherFacadeException : FacadeException
    {
        public OtherFacadeException(Exception innerException)
            : base("Error.", innerException, stackTrace: true) { }
    }
}
