using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates
{
    abstract class ValueBase : PredicateElement
    {
        public override string ToString(PositionStep[] position)
        {
            var tokenType = position.Last().TokenType;
            var value = position.Last().Value;
            if (tokenType == JsonToken.Null)
                return "null";
            if (tokenType == JsonToken.Undefined)
                return "undefined";
            if (tokenType == JsonToken.Boolean)
                return value.ToString().ToLowerInvariant();
            return value.ToString();
        }
    }
}
