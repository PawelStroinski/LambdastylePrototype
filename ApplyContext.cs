﻿using System;
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
        public readonly Action<string, Sentence, bool> Write;
        public readonly Func<Sentence, bool> Written;
        public readonly GlobalState State;
        public readonly Sentence[] Previous;

        public ApplyContext(IEnumerator<Sentence> style, PositionStep[] position, Action<string, Sentence, bool> write,
            Func<Sentence, bool> written, GlobalState state, params Sentence[] previous)
        {
            Style = style;
            Position = position;
            Write = write;
            Written = written;
            State = state;
            Previous = previous;
        }

        public ApplyContext Copy(Sentence caller)
        {
            return new ApplyContext(
                style: Style,
                position: Position,
                write: Write,
                written: Written,
                state: State,
                previous: Previous.Concat(new Sentence[] { caller }).ToArray());
        }
    }
}
