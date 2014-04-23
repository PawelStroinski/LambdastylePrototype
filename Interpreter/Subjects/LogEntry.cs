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
        public readonly PositionStep[] Position;

        public LogEntry(Type type, bool tail)
            : this(type: type, tail: tail, position: null)
        {
        }

        public LogEntry(Type type, bool tail, PositionStep[] position)
        {
            Type = type;
            Tail = tail;
            Position = position;
        }

        public LogEntry Copy(PositionStep[] position)
        {
            return new LogEntry(
                type: Type,
                tail: Tail,
                position: position);
        }
    }
}
