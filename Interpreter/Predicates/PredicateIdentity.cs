using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class PredicateIdentity
    {
#if DEBUG
        readonly static Random random = new Random();
        readonly int debuggingId = random.Next(100);

        public override string ToString()
        {
            return debuggingId.ToString();
        }
#endif
    }
}
