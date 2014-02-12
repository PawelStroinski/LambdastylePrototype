using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class OuterId : PredicateElement
    {
        public override bool AppliesAt(PositionStep[] position)
        {
            var tokenType = position.Last().TokenType;
            if (tokenType == JsonToken.EndObject)
                return false;
            if (position.HasPenultimate())
            {
                tokenType = position.Penultimate().TokenType;
                return tokenType == JsonToken.PropertyName;
            }
            return false;
        }

        public override string ToString(PositionStep[] position, GlobalState state)
        {
            var propertyName = position.Penultimate();
            var delimitersBefore = propertyName.DelimitersBefore;
            if (state.ProtectSyntax.Value && !state.WrittenOuter)
                delimitersBefore = string.Empty;
            state.WrittenOuter = true;
            return string.Format("{0}\"{1}\"{2}", delimitersBefore, propertyName.Value, propertyName.DelimitersAfter);
        }
    }
}
