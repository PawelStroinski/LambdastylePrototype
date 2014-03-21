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
        public readonly Type[] AppliedCases;

        public CaseContext(PredicateContext context, PredicateElement[] elements, bool writing,
            params Type[] appliedCases)
        {
            Context = context;
            Elements = elements;
            Writing = writing;
            AppliedCases = appliedCases;
        }

        public CaseContext Copy(PredicateElement[] elements, Type[] appliedCases)
        {
            return new CaseContext(
                context: Context,
                elements: elements,
                writing: Writing,
                appliedCases: appliedCases);
        }
    }
}
