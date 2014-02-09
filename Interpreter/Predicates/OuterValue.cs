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

        public override string ToString(PositionStep[] position)
        {
            var delimitersBefore = position.Last().DelimitersBefore;
            return delimitersBefore + ToStringInternal(position);
        }

        string ToStringInternal(PositionStep[] position)
        {
            var tokenType = position.Last().TokenType;
            if (tokenType == JsonToken.String)
                return "\"" + base.ToString(position) + "\"";
            if (tokenType == JsonToken.EndArray)
                return "]";
            if (tokenType == JsonToken.EndObject)
                return "}";
            if (tokenType == JsonToken.StartArray)
                return "[";
            if (tokenType == JsonToken.StartObject)
                return "{";
            return base.ToString(position);
        }
    }
}
