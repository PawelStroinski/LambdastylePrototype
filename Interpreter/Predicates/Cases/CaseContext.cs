using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates.Cases
{
    struct CaseContext
    {
        public readonly PredicateContext Context;
        public readonly PredicateElement[] Elements;
        public readonly bool Writing;

        public CaseContext(PredicateContext context, PredicateElement[] elements, bool writing)
        {
            Context = context;
            Elements = elements;
            Writing = writing;
        }

        public CaseContext Copy(PredicateElement[] elements)
        {
            return new CaseContext(
                context: Context,
                elements: elements,
                writing: Writing);
        }
    }
}
