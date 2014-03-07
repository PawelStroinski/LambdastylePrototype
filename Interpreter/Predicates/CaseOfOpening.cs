using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class CaseOfOpening : Case
    {
        PredicateElement[] elementsFromRaw;
        PredicateElement firstRaw, lastRaw;

        public new static int Order = CaseOfJoining.Order - 1;

        bool AppliesAt(PredicateContext context, PredicateElement[] elements)
        {
            var position = context.Position;
            if (!position.IsInArray() && !position.EndsWith(JsonToken.StartArray))
                return false;
            elementsFromRaw = elements.SkipWhile(element => !(element is Raw)).ToArray();
            var rawInnerValueAndRaw = elementsFromRaw.AreOfTypes(typeof(Raw), typeof(InnerValue), typeof(Raw));
            if (!rawInnerValueAndRaw)
                return false;
            firstRaw = elementsFromRaw.First();
            lastRaw = elementsFromRaw.Last();
            var firstRawValue = firstRaw.ToString(context).Result;
            var lastRawValue = lastRaw.ToString(context).Result;
            var startsWithStartArrayRegExp = new Regex(@"^\s*\[");
            var endsWithEndArrayRegExp = new Regex(@"\]\s*$");
            return startsWithStartArrayRegExp.IsMatch(firstRawValue) && endsWithEndArrayRegExp.IsMatch(lastRawValue);
        }

        public override PredicateElement[] ApplyTo(PredicateContext context, PredicateElement[] elements, bool writing)
        {
            if (AppliesAt(context, elements))
            {
                var position = context.Position;
                var elementsBeforeRaw = elements.Except(elementsFromRaw);
                if (position.EndsWith(JsonToken.StartArray))
                    return elementsBeforeRaw.Concat(firstRaw.Enclose()).ToArray();
                if (position.EndsWith(JsonToken.EndArray))
                    return new Override(lastRaw, appliesAt: (_) => true).Enclose().ToArray();
                return new OuterValue().Enclose().ToArray();
            }
            else
                return elements;
        }
    }
}
