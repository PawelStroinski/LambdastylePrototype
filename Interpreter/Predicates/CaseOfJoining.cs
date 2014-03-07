using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class CaseOfJoining : Case
    {
        bool innerValueAndRaw, rawInnerValueAndRaw;
        int firstRawLength, joiningLength;

        bool AppliesAt(PredicateContext context, PredicateElement[] elements)
        {
            var position = context.Position;
            if (!position.IsInArray())
                return false;
            innerValueAndRaw = elements.AreOfTypes(typeof(InnerValue), typeof(Raw));
            if (innerValueAndRaw)
                return true;
            rawInnerValueAndRaw = elements.AreOfTypes(typeof(Raw), typeof(InnerValue), typeof(Raw));
            if (!rawInnerValueAndRaw)
                return false;
            firstRawLength = elements.First().ToString(context).Result.Length;
            joiningLength = elements.Last().ToString(context).Result.Length;
            return firstRawLength < joiningLength;
        }

        public override PredicateElement[] ApplyTo(PredicateContext context, PredicateElement[] elements, bool writing)
        {
            if (AppliesAt(context, elements))
            {
                var joining = (Raw)elements.Last();
                var withoutJoining = elements.Take(elements.Length - 1);
                var continuation = context.GlobalState.Joining == joining;
                if (writing)
                    context.GlobalState.Joining = joining;
                if (rawInnerValueAndRaw)
                {
                    var joiningFull = joining.ToString(context).Result;
                    var joiningFirstHalf = joiningFull.Substring(0, firstRawLength);
                    var joiningSecondHalf = joiningFull.Substring(firstRawLength);
                    withoutJoining = withoutJoining.Concat(new Raw(joiningFirstHalf).Enclose());
                    joining = new Raw(joiningSecondHalf);
                }
                return (continuation ? joining.Enclose().Concat(withoutJoining) : withoutJoining).ToArray();
            }
            else
                return elements;
        }
    }
}
