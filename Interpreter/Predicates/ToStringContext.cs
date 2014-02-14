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

        public ToStringContext(PositionStep[] position, GlobalState globalState)
        {
            Position = position;
            GlobalState = globalState;
            HasOuter = false;
        }

        public ToStringContext(GlobalState globalState)
            : this(new PositionStep[0], globalState)
        {
        }

        public ToStringContext Copy(bool hasOuter)
        {
            return new ToStringContext(
                position: Position,
                globalState: GlobalState,
                hasOuter: hasOuter);
        }

        ToStringContext(PositionStep[] position, GlobalState globalState, bool hasOuter)
            : this(position, globalState)
        {
            HasOuter = hasOuter;
        }
    }
}
