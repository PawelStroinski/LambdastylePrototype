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
        public override bool AppliesAt(PositionStep[] position)
        {
            var tokenType = position.Last().TokenType;
            return tokenType != JsonToken.PropertyName;
        }

        public override string ToString(ToStringContext context)
        {
            var delimitersBefore = context.Position.Last().DelimitersBefore;
            context.GlobalState.WrittenOuter = true;
            return delimitersBefore + ToStringInternal(context);
        }

        string ToStringInternal(ToStringContext context)
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
