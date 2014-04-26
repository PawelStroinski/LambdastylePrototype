using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
            if (context.GlobalState.ForceSyntax.Value
                    && context.ApplyingStart
                    && context.GlobalState.WrittenPredicate.Contains(context.PredicateIdentity)
                    && !context.ApplyingTail
                    && !context.GlobalState.LastApplyingTail
                    && !context.Position.IsInArray()
                    && !context.Position.LastTokenType().IsEnd())
                return true;
            if (context.GlobalState.WrittenInThisObject
                    && elements.AreOfTypes(typeof(OuterValue), typeof(Raw))
                    && context.Position.HasPenultimate()
                    && context.Position.Penultimate().TokenType == JsonToken.PropertyName
                    && Regex.IsMatch(input: elements.Last().ToString(context).Result, pattern: Consts.StartsWithColon))
                return true;
            return false;
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
