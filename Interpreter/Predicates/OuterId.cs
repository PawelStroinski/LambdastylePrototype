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
        public override bool AppliesAt(PredicateContext context)
        {
            var position = context.Position;
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

        public override ToStringResult ToString(PredicateContext context)
        {
            var propertyName = context.Position.Penultimate();
            var delimitersBefore = context.DelimitersBefore ? propertyName.DelimitersBefore : string.Empty;
            if (context.GlobalState.ForceSyntax.Value && !context.GlobalState.WrittenOuter)
                delimitersBefore = string.Empty;
            if (!context.GlobalState.WrittenInThisObject && delimitersBefore.Contains(","))
                delimitersBefore = delimitersBefore.Replace(",", string.Empty);
            if (context.GlobalState.WrittenInThisObject && context.DelimitersBefore && !context.ApplyingTail)
                delimitersBefore = delimitersBefore.EnforceComma();
            context.GlobalState.WrittenOuter = true;
            context.GlobalState.WrittenInThisObject = true;
            return Result(string.Format("{0}\"{1}\"{2}",
                    delimitersBefore, propertyName.Value, propertyName.DelimitersAfter),
                hasDelimitersBefore: delimitersBefore != string.Empty);
        }
    }
}
