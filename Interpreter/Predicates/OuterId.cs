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

        public override string ToString(ToStringContext context)
        {
            var propertyName = context.Position.Penultimate();
            var delimitersBefore = propertyName.DelimitersBefore;
            if (context.GlobalState.ForceSyntax.Value && !context.GlobalState.WrittenOuter)
                delimitersBefore = string.Empty;
            context.GlobalState.WrittenOuter = true;
            return string.Format("{0}\"{1}\"{2}", delimitersBefore, propertyName.Value, propertyName.DelimitersAfter);
        }
    }
}
