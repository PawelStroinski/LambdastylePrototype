using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates
{
    abstract class PredicateElement : SyntaxElement
    {
        public virtual bool AppliesAt(PositionStep[] position)
        {
            return true;
        }

        public abstract string ToString(PositionStep[] position, GlobalState state);
    }
}
