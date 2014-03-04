using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class OuterValue : ValueBase
    {
        public override bool AppliesAt(PredicateContext context)
        {
            var tokenType = context.Position.Last().TokenType;
            var writtenEndArray = context.GlobalState.WrittenEndArray.Contains(context.PredicateIdentity);
            var arrayBoundry = tokenType == JsonToken.StartArray || tokenType == JsonToken.EndArray;
            if (writtenEndArray && arrayBoundry)
                return false;
            return tokenType != JsonToken.PropertyName;
        }

        public override ToStringResult ToString(PredicateContext context)
        {
            var delimitersBefore = context.DelimitersBefore ? context.Position.Last().DelimitersBefore : string.Empty;
            var writtenEndArray = context.GlobalState.WrittenEndArray.Contains(context.PredicateIdentity);
            var seeked = context.GlobalState.Seeked.Contains(context.PredicateIdentity);
            var seekBy = 0;
            if (writtenEndArray && !delimitersBefore.Contains(','))
                delimitersBefore = "," + (delimitersBefore == string.Empty ? " " : delimitersBefore);
            if (writtenEndArray && !seeked)
                seekBy = -1;
            context.GlobalState.WrittenOuter = true;
            var internalResult = ToStringInternal(context);
            return internalResult.Copy(delimitersBefore + internalResult.Result, seekBy: seekBy);
        }

        ToStringResult ToStringInternal(PredicateContext context)
        {
            var tokenType = context.Position.Last().TokenType;
            context.GlobalState.WrittenInThisObject = tokenType != JsonToken.StartObject;
            if (tokenType == JsonToken.String)
            {
                var baseResult = base.ToString(context);
                return baseResult.Copy("\"" + baseResult.Result + "\"");
            }
            if (tokenType == JsonToken.EndArray)
            {
                context.GlobalState.WrittenEndArray.Add(context.PredicateIdentity);
                return Result("]");
            }
            if (tokenType == JsonToken.EndObject)
                return Result("}");
            if (tokenType == JsonToken.StartArray)
                return Result("[");
            if (tokenType == JsonToken.StartObject)
                return Result("{");
            return base.ToString(context);
        }
    }
}
