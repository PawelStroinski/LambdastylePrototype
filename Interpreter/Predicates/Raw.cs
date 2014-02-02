using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class Raw : PredicateElement
    {
        readonly string raw;

        public Raw(string raw)
        {
            this.raw = raw;
        }

        public override string ToString(PositionStep[] position)
        {
            return raw;
        }
    }
}
