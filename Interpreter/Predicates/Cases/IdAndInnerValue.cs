using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates.Cases
{
    class IdAndInnerValue : Case
    {
        PredicateContext context;
        PredicateElement[] elements;

        public new static int Order = Tail.Order - 1;

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
            var hasIdAndInnerValue = elements.Any(element => element is OuterId)
                && elements.Any(element => element is InnerValue);
            var applyingTail = context.ApplyingTail || context.GlobalState.LastApplyingTail
                || context.GlobalState.PredicateScope.Written() || context.ApplyingParent;
            return hasIdAndInnerValue && applyingTail;
        }
    }
}
