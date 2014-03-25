using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates.Cases
{
    class TailBoundary : Case
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
            if (AppliesAt())
                return new PredicateElement[0];
            else
                return elements;
        }

        bool AppliesAt()
        {
            var applyingTail = context.ApplyingTail || context.GlobalState.LastApplyingTail;
            if (caseContext.AppliedCases.Contains<Tail>() && !applyingTail)
            {
                var tokenType = context.Position.Last().TokenType;
                var used = context.GlobalState.TailBoundaryUsed;
                var wasUsed = used.ContainsKey(context.PredicateIdentity);
                if (tokenType.IsStart() && !wasUsed)
                {
                    used[context.PredicateIdentity] = context.Position;
                    return true;
                }
                if (tokenType.IsEnd() && wasUsed
                        && used[context.PredicateIdentity].SequenceEqual(context.Position.ExceptLast()))
                    return true;
            }
            return false;
        }
    }
}
