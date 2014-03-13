using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates.Cases
{
    class Wrapping : Case
    {
        PredicateContext context;
        PredicateElement[] elements;
        PredicateElement lastRaw, lastOuterValue;

        public override PredicateElement[] ApplyTo(CaseContext caseContext)
        {
            context = caseContext.Context;
            elements = caseContext.Elements;
            if (AppliesAt())
            {
                var rawLength = lastRaw.ToString(context).Result.Length;
                var proxy = new Proxy(lastOuterValue, toString: (result, _) => new ToStringResult(
                    result.Result, hasDelimitersBefore: result.HasDelimitersBefore, seekBy: result.SeekBy - rawLength));
                return elements.Select(element => element == lastOuterValue ? proxy : element).ToArray();
            }
            else
                return elements;
        }

        bool AppliesAt()
        {
            lastRaw = elements.LastOrDefault(element => element is Raw);
            lastOuterValue = elements.LastOrDefault(element => element is OuterValue);
            var elementsList = elements.ToList();
            var lastRawIsAfterOuterValue = lastRaw != null && lastOuterValue != null
                && elementsList.IndexOf(lastRaw) > elementsList.IndexOf(lastOuterValue);
            var applyingTail = context.ApplyingTail || context.GlobalState.LastApplyingTail;
            return lastRawIsAfterOuterValue && applyingTail;
        }
    }
}
