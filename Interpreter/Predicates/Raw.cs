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
                var writtenRaw = context.GlobalState.WrittenRaw
                    .Any(tuple => tuple.Item1 == context.PredicateIdentity && tuple.Item2 == this);
                if (inItem && !context.ApplyingItem && writtenRaw)
                    return false;
                var writtenEndArray = context.GlobalState.WrittenEndArray.Contains(context.PredicateIdentity);
                var atStartArray = tokenType == JsonToken.StartArray;
                if (writtenEndArray && atStartArray)
                    return false;
                if (context.ApplyingTail)
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
                if (Regex.IsMatch(input: raw, pattern: Consts.StartsWithPropertyName)
                        && position.HasPenultimate()
                        && position.Penultimate().TokenType == JsonToken.PropertyName)
                    delimitersBefore = position.Penultimate().DelimitersBefore;
                if (!context.GlobalState.WrittenInThisObject)
                    delimitersBefore = delimitersBefore.Replace(",", string.Empty);
            }
            context.GlobalState.WrittenRaw.Add(new Tuple<PredicateIdentity, Raw>(context.PredicateIdentity, this));
            return Result(delimitersBefore + raw, hasDelimitersBefore: delimitersBefore != string.Empty);
        }
    }
}
