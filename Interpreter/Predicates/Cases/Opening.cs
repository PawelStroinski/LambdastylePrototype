using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates.Cases
{
    class Opening : Case
    {
        PredicateContext context;
        PredicateElement[] elements, elementsFromRaw;
        PredicateElement firstRaw, lastRaw;

        public new static int Order = Joining.Order - 1;

        public override PredicateElement[] ApplyTo(CaseContext caseContext)
        {
            context = caseContext.Context;
            elements = caseContext.Elements;
            if (AppliesAt())
            {
                var position = context.Position;
                var elementsBeforeRaw = elements.Except(elementsFromRaw);
                if (position.EndsWith(JsonToken.StartArray))
                    return elementsBeforeRaw.Concat(firstRaw.Enclose()).ToArray();
                if (position.EndsWith(JsonToken.EndArray))
                    return new Proxy(lastRaw, appliesAt: (_, __) => true).Enclose().ToArray();
                return new OuterValue().Enclose().ToArray();
            }
            else
                return elements;
        }

        bool AppliesAt()
        {
            var position = context.Position;
            if (!position.Any(step => step.TokenType == JsonToken.StartArray))
                return false;
            if (context.ApplyingItem)
                return false;
            elementsFromRaw = elements.SkipWhile(element => !(element is Raw)).ToArray();
            var rawInnerValueAndRaw = elementsFromRaw.AreOfTypes(typeof(Raw), typeof(InnerValue), typeof(Raw));
            if (!rawInnerValueAndRaw)
                return false;
            firstRaw = elementsFromRaw.First();
            lastRaw = elementsFromRaw.Last();
            var firstRawValue = firstRaw.ToString(context).Result;
            var lastRawValue = lastRaw.ToString(context).Result;
            return Regex.IsMatch(input: firstRawValue, pattern: Consts.StartsWithStartArray)
                && Regex.IsMatch(input: lastRawValue, pattern: Consts.EndsWithEndArray);
        }
    }
}
