using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates.Cases
{
    class Joining : Case
    {
        PredicateContext context;
        PredicateElement[] elements; 
        bool innerValueAndRaw, rawInnerValueAndRaw;
        int firstRawLength, joiningLength;

        public override PredicateElement[] ApplyTo(CaseContext caseContext)
        {
            context = caseContext.Context;
            elements = caseContext.Elements;
            if (AppliesAt())
            {
                var joining = (Raw)elements.Last();
                var withoutJoining = elements.Take(elements.Length - 1);
                var continuation = context.GlobalState.Joining == joining;
                if (caseContext.Writing)
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

        bool AppliesAt()
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
    }
}
