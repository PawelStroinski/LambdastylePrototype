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
        public readonly string[] RegExpGroups;

        public LogEntry(Type type, bool tail)
            : this(type: type, tail: tail, position: null, regExpGroups: null)
        {
        }

        public LogEntry(Type type, bool tail, PositionStep[] position, string[] regExpGroups)
        {
            Type = type;
            Tail = tail;
            Position = position;
            RegExpGroups = regExpGroups;
        }

        public LogEntry Copy(PositionStep[] position)
        {
            return new LogEntry(
                type: Type,
                tail: Tail,
                position: position,
                regExpGroups: RegExpGroups);
        }
    }
}
