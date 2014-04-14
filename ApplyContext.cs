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
        public readonly Action<Sentence[], bool> Spawn;
        public readonly PositionStep[] SpawnerPosition;
        public readonly GlobalState GlobalState;
        public readonly SentenceScope SentenceScope;
        public readonly ParentScope ParentScope;
        public readonly ReducedsScope ReducedsScope;
        public readonly bool Scan;
        public readonly bool Strict;
        public readonly bool SpawnerCanCopy;
        public readonly Sentence[] Previous;

        public ApplyContext(IEnumerator<Sentence> style, PositionStep[] position,
            Action<string, Sentence, bool, int> write, Func<Sentence, bool> written, Action<Sentence[], bool> spawn,
            PositionStep[] spawnerPosition, GlobalState globalState, SentenceScope sentenceScope,
            ParentScope parentScope, ReducedsScope reducedsScope, bool scan, bool strict, bool spawnerCanCopy,
            params Sentence[] previous)
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
            ReducedsScope = reducedsScope;
            Scan = scan;
            Strict = strict;
            SpawnerCanCopy = spawnerCanCopy;
            Previous = previous;
        }

        public ApplyContext Copy(Sentence caller)
        {
            return this.Copy(caller: caller, style: Style, spawnerPosition: SpawnerPosition, scan: Scan,
                strict: Strict, spawnerCanCopy: SpawnerCanCopy);
        }

        public ApplyContext Copy(Sentence caller, IEnumerator<Sentence> style, PositionStep[] spawnerPosition,
            bool scan, bool spawnerCanCopy)
        {
            return this.Copy(caller: caller, style: style, spawnerPosition: spawnerPosition, scan: scan,
                strict: Strict, spawnerCanCopy: spawnerCanCopy);
        }

        public ApplyContext Copy(Sentence caller, bool strict)
        {
            return this.Copy(caller: caller, style: Style, spawnerPosition: SpawnerPosition, scan: Scan,
                strict: strict, spawnerCanCopy: SpawnerCanCopy);
        }

        ApplyContext Copy(Sentence caller, IEnumerator<Sentence> style, PositionStep[] spawnerPosition, bool scan,
            bool strict, bool spawnerCanCopy)
        {
            return new ApplyContext(
                style: style,
                position: Position,
                write: Write,
                written: Written,
                spawn: Spawn,
                spawnerPosition: spawnerPosition,
                globalState: GlobalState,
                sentenceScope: SentenceScope,
                parentScope: ParentScope,
                reducedsScope: ReducedsScope,
                scan: scan,
                strict: strict,
                spawnerCanCopy: spawnerCanCopy,
                previous: Previous.Concat(new Sentence[] { caller }).ToArray());
        }
    }
}
