using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class CaseOfTail : Case
    {
        PredicateContext context;
        PredicateElement[] elements;

        bool AppliesAt()
        {
            return context.ApplyingTail && HasOuterValue() && !HasOuterId();
        }

        public override PredicateElement[] ApplyTo(PredicateContext context, PredicateElement[] elements, bool writing)
        {
            this.context = context;
            this.elements = elements;
            if (AppliesAt())
                return InsertOuterIdBeforeOuterValue();
            else
                return elements;
        }

        bool HasOuterValue()
        {
            return elements.Any(element => element is OuterValue);
        }

        bool HasOuterId()
        {
            return elements.Any(element => element is OuterId);
        }

        PredicateElement[] InsertOuterIdBeforeOuterValue()
        {
            var elementsList = elements.ToList();
            var outerValueIndex = elementsList.IndexOf(elementsList.OfType<OuterValue>().First());
            elementsList.Insert(outerValueIndex, new OuterId());
            return elementsList.ToArray();
        }
    }
}
