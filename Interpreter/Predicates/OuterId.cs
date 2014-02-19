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
            if (!context.GlobalState.WrittenInThisObject && delimitersBefore.Contains(","))
                delimitersBefore = RemoveExcessiveDelimiters(delimitersBefore);
            context.GlobalState.WrittenOuter = true;
            context.GlobalState.WrittenInThisObject = true;
            return string.Format("{0}\"{1}\"{2}", delimitersBefore, propertyName.Value, propertyName.DelimitersAfter);
        }

        string RemoveExcessiveDelimiters(string delimiters)
        {
            delimiters = delimiters.Replace(",", string.Empty);
            var lastLineBreak = Math.Max(delimiters.LastIndexOf('\r'), delimiters.LastIndexOf('\n'));
            if (lastLineBreak == -1)
                return delimiters;
            delimiters = delimiters.Substring(lastLineBreak + 1);
            return delimiters.Length > 1 ? delimiters.Substring(1) : delimiters;
        }
    }
}
