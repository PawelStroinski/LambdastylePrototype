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

        public override ToStringResult ToString(PredicateContext context)
        {
            var groupNumber = this.groupNumber - 1;
            if (groupNumber >= 0 && groupNumber < context.RegExpGroups.Length)
                return Result(context.RegExpGroups[groupNumber]);
            else
                return Result(string.Empty);
        }
    }
}
