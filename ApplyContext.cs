using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter;

namespace LambdastylePrototype
{
    struct ApplyContext
    {
        public readonly IEnumerator<Sentence> Style;
        public readonly PositionStep[] Position;
        public readonly Action<string, Sentence> Write;
        public readonly Func<Sentence, bool> Written;
        public readonly Sentence[] Previous;

        public ApplyContext(IEnumerator<Sentence> style, PositionStep[] position, Action<string, Sentence> write,
            Func<Sentence, bool> written, params Sentence[] previous)
        {
            Style = style;
            Position = position;
            Write = write;
            Written = written;
            Previous = previous;
        }

        public ApplyContext Copy(Sentence caller)
        {
            return new ApplyContext(
                style: Style,
                position: Position,
                write: Write,
                written: Written,
                previous: Previous.Concat(new Sentence[] { caller }).ToArray());
        }
    }
}
