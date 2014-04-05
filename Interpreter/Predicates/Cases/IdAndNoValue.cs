using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates.Cases
{
    class IdAndNoValue : Case
    {
        PredicateContext context;
        PredicateElement[] elements;

        public override PredicateElement[] ApplyTo(CaseContext caseContext)
        {
            context = caseContext.Context;
            elements = caseContext.Elements;
            if (AppliesAt())
                return elements.Where(element => !(element is OuterId)).ToArray();
            else
                return elements;
        }

        bool AppliesAt()
        {
            var hasIdAndDoesntHaveValue = elements.Any(element => element is OuterId)
                && !elements.Any(element => element is ValueBase);
            return hasIdAndDoesntHaveValue && context.ApplyingTail;
        }
    }
}
