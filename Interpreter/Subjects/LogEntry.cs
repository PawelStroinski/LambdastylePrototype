using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    struct LogEntry
    {
        public readonly Type Type;
        public readonly bool Tail;

        public LogEntry(Type type, bool tail)
        {
            Type = type;
            Tail = tail;
        }
    }
}
