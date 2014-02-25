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
            return tokenType != JsonToken.PropertyName;
        }

        public override string ToString(PredicateContext context)
        {
            var delimitersBefore = context.Position.Last().DelimitersBefore;
            context.GlobalState.WrittenOuter = true;
            if (context.GlobalState.SkipDelimitersBeforeInOuterValue)
                delimitersBefore = string.Empty;
            return delimitersBefore + ToStringInternal(context);
        }

        string ToStringInternal(PredicateContext context)
        {
            var tokenType = context.Position.Last().TokenType;
            context.GlobalState.WrittenInThisObject = tokenType != JsonToken.StartObject;
            if (tokenType == JsonToken.String)
                return "\"" + base.ToString(context) + "\"";
            if (tokenType == JsonToken.EndArray)
                return "]";
            if (tokenType == JsonToken.EndObject)
                return "}";
            if (tokenType == JsonToken.StartArray)
                return "[";
            if (tokenType == JsonToken.StartObject)
                return "{";
            return base.ToString(context);
        }
    }
}
