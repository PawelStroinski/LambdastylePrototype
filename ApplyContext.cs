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
        public readonly Action<string, Sentence, bool, int> Write;
        public readonly Func<Sentence, bool> Written;
        public readonly Action<Sentence[]> Spawn;
        public readonly PositionStep[] SpawnerPosition;
        public readonly GlobalState GlobalState;
        public readonly SentenceScope SentenceScope;
        public readonly ParentScope ParentScope;
        public readonly bool Scan;
        public readonly bool Strict;
        public readonly Sentence[] Previous;

        public ApplyContext(IEnumerator<Sentence> style, PositionStep[] position,
            Action<string, Sentence, bool, int> write, Func<Sentence, bool> written, Action<Sentence[]> spawn,
            PositionStep[] spawnerPosition, GlobalState globalState, SentenceScope sentenceScope,
            ParentScope parentScope, bool scan, bool strict, params Sentence[] previous)
        {
            Style = style;
            Position = position;
            Write = write;
            Written = written;
            Spawn = spawn;
            SpawnerPosition = spawnerPosition;
            GlobalState = globalState;
            SentenceScope = sentenceScope;
            ParentScope = parentScope;
            Scan = scan;
            Strict = strict;
            Previous = previous;
        }

        public ApplyContext Copy(Sentence caller)
        {
            return this.Copy(caller: caller, style: Style, scan: Scan, strict: Strict);
        }

        public ApplyContext Copy(Sentence caller, IEnumerator<Sentence> style, bool scan)
        {
            return this.Copy(caller: caller, style: style, scan: scan, strict: Strict);
        }

        public ApplyContext Copy(Sentence caller, bool strict)
        {
            return this.Copy(caller: caller, style: Style, scan: Scan, strict: strict);
        }

        ApplyContext Copy(Sentence caller, IEnumerator<Sentence> style, bool scan, bool strict)
        {
            return new ApplyContext(
                style: style,
                position: Position,
                write: Write,
                written: Written,
                spawn: Spawn,
                spawnerPosition: SpawnerPosition,
                globalState: GlobalState,
                sentenceScope: SentenceScope,
                parentScope: ParentScope,
                scan: scan,
                strict: strict,
                previous: Previous.Concat(new Sentence[] { caller }).ToArray());
        }
    }
}
