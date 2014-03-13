using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates.Cases
{
    class Tail : Case
    {
        PredicateContext context;
        PredicateElement[] elements;

        public override PredicateElement[] ApplyTo(CaseContext caseContext)
        {
            context = caseContext.Context;
            elements = caseContext.Elements;
            if (AppliesAt())
                return InsertOuterIdBeforeOuterValue();
            else
                return elements;
        }

        bool AppliesAt()
        {
            return context.ApplyingTail && HasOuterValue() && !HasOuterId();
        }

        PredicateElement[] InsertOuterIdBeforeOuterValue()
        {
            var elementsList = elements.ToList();
            var outerValueIndex = elementsList.IndexOf(elementsList.OfType<OuterValue>().First());
            elementsList.Insert(outerValueIndex, new OuterId());
            return elementsList.ToArray();
        }

        bool HasOuterValue()
        {
            return elements.Any(element => element is OuterValue);
        }

        bool HasOuterId()
        {
            return elements.Any(element => element is OuterId);
        }
    }
}
