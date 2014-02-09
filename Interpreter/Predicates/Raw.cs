using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class Raw : PredicateElement
    {
        readonly string raw;

        public Raw(string raw)
        {
            this.raw = raw;
        }

        public override bool AppliesAt(PositionStep[] position)
        {
            if (position.Any())
            {
                var tokenType = position.Last().TokenType;
                return tokenType != JsonToken.EndObject && tokenType != JsonToken.EndArray;
            }
            return true;
        }

        public override string ToString(PositionStep[] position)
        {
            return raw;
        }
    }
}
