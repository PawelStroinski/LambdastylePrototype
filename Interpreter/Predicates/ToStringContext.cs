using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates
{
    struct ToStringContext
    {
        public readonly PositionStep[] Position;
        public readonly GlobalState GlobalState;
        public readonly bool HasOuter;
        public readonly bool AllowNewLine;

        public ToStringContext(PositionStep[] position, GlobalState globalState, bool hasOuter, bool allowNewLine)
        {
            Position = position;
            GlobalState = globalState;
            HasOuter = hasOuter;
            AllowNewLine = allowNewLine;
        }

        public ToStringContext(PositionStep[] position, GlobalState globalState)
            : this(position, globalState, hasOuter: false, allowNewLine: true)
        {
        }

        public ToStringContext(GlobalState globalState)
            : this(new PositionStep[0], globalState)
        {
        }

        public ToStringContext(GlobalState globalState, bool allowNewLine)
            : this(globalState)
        {
            AllowNewLine = allowNewLine;
        }

        public ToStringContext Copy(bool hasOuter)
        {
            return new ToStringContext(
                position: Position,
                globalState: GlobalState,
                hasOuter: hasOuter,
                allowNewLine: AllowNewLine);
        }
    }
}
