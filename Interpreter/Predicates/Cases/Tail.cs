using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates.Cases
{
    class Tail : Case
    {
        PredicateContext context;
        PredicateElement[] elements;

        public new static int Order = Wrapping.Order - 1;

        public override PredicateElement[] ApplyTo(CaseContext caseContext)
        {
            context = caseContext.Context;
            elements = caseContext.Elements;
            if (AppliesAtOuter())
                return InsertOuterIdBeforeOuterValue();
            else
                if (AppliesAtInner())
                    return ReplaceInnerValueWithOuterIdAndOuterValue();
                else
                    return elements;
        }

        bool AppliesAtOuter()
        {
            var tailOrParent = context.ApplyingTail || context.ApplyingParent;
            return tailOrParent && HasOuterValue() && !HasOuterId();
        }

        bool AppliesAtInner()
        {
            var parent = context.ApplyingParent
                && (!context.ApplyingStart || context.GlobalState.PredicateScope.Written());
            var tailOrParent = context.ApplyingTail || parent;
            return tailOrParent && HasInnerValue() && !HasOuterId() && !HasOuterValue();
        }

        PredicateElement[] InsertOuterIdBeforeOuterValue()
        {
            var elementsList = elements.ToList();
            var outerValueIndex = elementsList.IndexOf(elementsList.OfType<OuterValue>().First());
            elementsList.Insert(outerValueIndex, new OuterId());
            return elementsList.ToArray();
        }

        PredicateElement[] ReplaceInnerValueWithOuterIdAndOuterValue()
        {
            var elementsList = elements.ToList();
            var innerValueIndex = elementsList.IndexOf(elementsList.OfType<InnerValue>().First());
            elementsList.RemoveAt(innerValueIndex);
            elementsList.Insert(innerValueIndex, new OuterValue());
            elementsList.Insert(innerValueIndex, new OuterId());
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

        bool HasInnerValue()
        {
            return elements.Any(element => element is InnerValue);
        }
    }
}
