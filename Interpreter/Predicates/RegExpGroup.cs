using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class RegExpGroup : ValueBase
    {
        readonly int groupNumber;

        public RegExpGroup(int groupNumber)
        {
            this.groupNumber = groupNumber;
        }

        public override string ToString(PredicateContext context)
        {
            throw new NotImplementedException();
        }
    }
}
