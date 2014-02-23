using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class Joining
    {
        readonly ToStringContext context;
        readonly PredicateElement[] elements;
        bool innerValueAndRaw, rawInnerValueAndRaw;
        int firstRawLength, joiningLength;

        public Joining(ToStringContext context, PredicateElement[] elements)
        {
            this.context = context;
            this.elements = elements;
            IsJoining = GetIsJoining();
        }

        public bool IsJoining { get; private set; }

        bool GetIsJoining()
        {
            var position = context.Position;
            var inArray = position.HasPenultimate() && position.Penultimate().TokenType == JsonToken.StartArray;
            if (!inArray)
                return false;
            innerValueAndRaw = elements.AreOfTypes(typeof(InnerValue), typeof(Raw));
            if (innerValueAndRaw)
                return true;
            rawInnerValueAndRaw = elements.AreOfTypes(typeof(Raw), typeof(InnerValue), typeof(Raw));
            if (!rawInnerValueAndRaw)
                return false;
            firstRawLength = elements.First().ToString(context).Length;
            joiningLength = elements.Last().ToString(context).Length;
            if (firstRawLength < joiningLength)
                return true;
            return false;
        }

        public PredicateElement[] JoinElements()
        {
            if (IsJoining)
            {
                var joining = (Raw)elements.Last();
                var withoutJoining = elements.Take(elements.Length - 1);
                var continuation = context.GlobalState.Joining == joining;
                context.GlobalState.Joining = joining;
                if (rawInnerValueAndRaw)
                {
                    var joiningFull = joining.ToString(context);
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
