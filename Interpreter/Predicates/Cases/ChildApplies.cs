using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates.Cases
{
    class ChildApplies : Case
    {
        CaseContext caseContext;
        PredicateContext context;
        PredicateElement[] elements;

        public new static int Order = Tail.Order + 1;

        public override PredicateElement[] ApplyTo(CaseContext caseContext)
        {
            this.caseContext = caseContext;
            context = caseContext.Context;
            elements = caseContext.Elements;
            if (AppliesAtTail())
                return elements.TakeWhile(element => element is Raw).ToArray();
            else
                if (AppliesAt())
                    return new PredicateElement[0];
                else
                    return elements;
        }

        bool AppliesAtTail()
        {
            return context.ChildApplies
                && caseContext.AppliedCases.Contains<Tail>()
                && elements.First() is Raw
                && !context.GlobalState.PredicateScope.Written();
        }

        bool AppliesAt()
        {
            return context.ChildApplies;
        }
    }
}
