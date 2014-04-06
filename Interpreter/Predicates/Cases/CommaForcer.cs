using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates.Cases
{
    class CommaForcer : Case
    {
        PredicateContext context;
        PredicateElement[] elements;

        public override PredicateElement[] ApplyTo(CaseContext caseContext)
        {
            context = caseContext.Context;
            elements = caseContext.Elements;
            if (AppliesAt())
                return CreateProxy(elements.First()).Enclose().Concat(elements.Skip(1)).ToArray();
            else
                return elements;
        }

        bool AppliesAt()
        {
            return context.GlobalState.ForceSyntax.Value
                && context.ApplyingStart
                && context.GlobalState.WrittenPredicate.Contains(context.PredicateIdentity)
                && !context.ApplyingTail
                && !context.GlobalState.LastApplyingTail
                && !context.Position.IsInArray()
                && !context.Position.LastTokenType().IsEnd();
        }

        Proxy CreateProxy(PredicateElement proxied)
        {
            return new Proxy(proxied, toString: (result, _) => new ToStringResult(
                result: result.Result.EnforceComma(),
                hasDelimitersBefore: result.HasDelimitersBefore,
                seekBy: result.SeekBy));
        }
    }
}
