using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates.Cases
{
    class SpawnTail : Case
    {
        PredicateContext context;
        PredicateElement[] elements;

        public override PredicateElement[] ApplyTo(CaseContext caseContext)
        {
            context = caseContext.Context;
            elements = caseContext.Elements;
            if (AppliesAt())
            {
                var tokenType = context.Position.LastTokenType();
                if (tokenType.IsStart())
                    return new PredicateElement[0];
                else
                    return new Raw("{").Enclose().Concat(new OuterId().Enclose().Concat(elements)).ToArray();
            }
            else
                return elements;
        }

        bool AppliesAt()
        {
            return context.ApplyingSpawn
                && !context.GlobalState.ForceSyntax.Value
                && elements.Length == 1
                && elements[0] is OuterValue;
        }
    }
}
