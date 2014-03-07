using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates
{
    abstract class Case
    {
        public static int Order = 0;

        public abstract PredicateElement[] ApplyTo(PredicateContext context, PredicateElement[] elements, bool writing);
    }
}
