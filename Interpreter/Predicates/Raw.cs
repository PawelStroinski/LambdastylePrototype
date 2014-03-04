using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public override bool AppliesAt(PredicateContext context)
        {
            var position = context.Position;
            if (position.Any())
            {
                var tokenType = position.Last().TokenType;
                if (tokenType == JsonToken.EndObject || tokenType == JsonToken.EndArray)
                    return false;
                var inItem = position.Take(position.Length - 1).Any(step => step.TokenType == JsonToken.StartArray);
                if (inItem && !context.ApplyingItem)
                    return false;
                var writtenEndArray = context.GlobalState.WrittenEndArray.Contains(context.PredicateIdentity);
                var atStartArray = tokenType == JsonToken.StartArray;
                if (writtenEndArray && atStartArray)
                    return false;
            }
            return true;
        }

        public override ToStringResult ToString(PredicateContext context)
        {
            var position = context.Position;
            var delimitersBefore = string.Empty;
            if (context.DelimitersBefore && context.HasOuter)
            {
                if (position.Any())
                    delimitersBefore = position.Last().DelimitersBefore;
                if (Regex.IsMatch(raw, Consts.StartsWithPropertyNameRegExp)
                    && position.HasPenultimate()
                    && position.Penultimate().TokenType == JsonToken.PropertyName)
                {
                    delimitersBefore = position.Penultimate().DelimitersBefore;
                    return new ToStringResult(delimitersBefore + raw, delimitersBeforeInNextOuterValue: false);
                }
            }
            return Result(delimitersBefore + raw);
        }
    }
}
