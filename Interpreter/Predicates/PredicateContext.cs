using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates
{
    struct PredicateContext
    {
        public readonly PositionStep[] Position;
        public readonly GlobalState GlobalState;
        public readonly bool HasOuter;
        public readonly bool AllowNewLine;
        public readonly bool ApplyingItem;

        public PredicateContext(PositionStep[] position, GlobalState globalState,
            bool hasOuter = false, bool allowNewLine = true, bool applyingItem = false)
        {
            Position = position;
            GlobalState = globalState;
            HasOuter = hasOuter;
            AllowNewLine = allowNewLine;
            ApplyingItem = applyingItem;
        }

        public PredicateContext(GlobalState globalState)
            : this(new PositionStep[0], globalState)
        {
        }

        public PredicateContext(GlobalState globalState, bool allowNewLine)
            : this(globalState)
        {
            AllowNewLine = allowNewLine;
        }

        public PredicateContext Copy(bool hasOuter)
        {
            return new PredicateContext(
                position: Position,
                globalState: GlobalState,
                hasOuter: hasOuter,
                allowNewLine: AllowNewLine,
                applyingItem: ApplyingItem);
        }
    }
}
