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
        public override string ToString()
        {
            return (GetHashCode() % 1000).ToString();
        }
#endif
    }
}
