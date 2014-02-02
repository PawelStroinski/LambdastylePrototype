using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates
{
    abstract class PredicateValue : PredicateElement
    {
        static JsonToken[] valueTokenTypes = { JsonToken.Boolean, JsonToken.Float, JsonToken.Integer,
                                                 JsonToken.Null, JsonToken.String, JsonToken.Undefined };

        public override bool AppliesAt(PositionStep[] position)
        {
            var tokenType = position.Last().TokenType;
            return valueTokenTypes.Contains(tokenType);
        }

        public override string ToString(PositionStep[] position)
        {
            var tokenType = position.Last().TokenType;
            var value = position.Last().Value;
            if (tokenType == JsonToken.Null)
                return "null";
            if (tokenType == JsonToken.Undefined)
                return "undefined";
            return value.ToString();
        }
    }
}
