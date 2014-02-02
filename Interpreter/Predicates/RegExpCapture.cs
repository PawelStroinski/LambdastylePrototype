using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class RegExpCapture : PredicateValue
    {
        readonly int groupNumber;

        public RegExpCapture(int groupNumber)
        {
            this.groupNumber = groupNumber;
        }

        public override string ToString(PositionStep[] position)
        {
            throw new NotImplementedException();
        }
    }
}
