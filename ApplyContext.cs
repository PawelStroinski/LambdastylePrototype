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
        public readonly bool Silent;
        public readonly Sentence[] Previous;

        public ApplyContext(IEnumerator<Sentence> style, PositionStep[] position,
            Action<string, Sentence, bool, int> write, Func<Sentence, bool> written, Action<Sentence[]> spawn,
            PositionStep[] spawnerPosition, GlobalState globalState, SentenceScope sentenceScope,
            ParentScope parentScope, bool silent, params Sentence[] previous)
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
            Silent = silent;
            Previous = previous;
        }

        public ApplyContext Copy(Sentence caller)
        {
            return this.Copy(Style, Silent, caller);
        }

        public ApplyContext Copy(IEnumerator<Sentence> style, bool silent, Sentence caller)
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
                silent: silent,
                previous: Previous.Concat(new Sentence[] { caller }).ToArray());
        }
    }
}
