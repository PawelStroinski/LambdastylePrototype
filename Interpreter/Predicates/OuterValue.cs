﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class OuterValue : ValueBase
    {
        public override bool AppliesAt(PredicateContext context)
        {
            if (!context.Position.Any())
                return false;
            var tokenType = context.Position.Last().TokenType;
            var writtenEndArray = context.GlobalState.WrittenEndArray.Contains(context.PredicateIdentity)
                && !context.ApplyingItem && !context.ApplyingTail && !context.GlobalState.LastApplyingTail
                && !context.ApplyingStart;
            var arrayBoundry = tokenType == JsonToken.StartArray || tokenType == JsonToken.EndArray;
            if (writtenEndArray && arrayBoundry)
                return false;
            else
                return true;
        }

        public override ToStringResult ToString(PredicateContext context)
        {
            var delimitersBefore = context.DelimitersBefore ? context.Position.Last().DelimitersBefore : string.Empty;
            var writtenEndArray = context.GlobalState.WrittenEndArray.Contains(context.PredicateIdentity)
                && !context.ApplyingItem && !context.ApplyingTail && !context.GlobalState.LastApplyingTail
                && !context.ApplyingParent && !context.ApplyingStart;
            var seeked = context.GlobalState.Seeked.Contains(context.PredicateIdentity);
            var seekBy = 0;
            if (writtenEndArray && context.DelimitersBefore)
                delimitersBefore = delimitersBefore.EnforceComma();
            if (writtenEndArray && !seeked)
                seekBy = -1;
            var tokenType = context.Position.Last().TokenType;
            if (context.GlobalState.WrittenInThisObject && context.ApplyingItem && context.Position.IsInArray()
                    && tokenType != JsonToken.EndArray && context.DelimitersBefore)
                delimitersBefore = delimitersBefore.EnforceComma();
            if (!context.GlobalState.WrittenInThisObject)
                delimitersBefore = delimitersBefore.Replace(",", "");
            context.GlobalState.WrittenOuter = true;
            context.GlobalState.WrittenInThisObject = true;
            return new ToStringResult(delimitersBefore + ToStringInternal(context).Result,
                hasDelimitersBefore: delimitersBefore != string.Empty, seekBy: seekBy);
        }

        ToStringResult ToStringInternal(PredicateContext context)
        {
            var tokenType = context.Position.Last().TokenType;
            context.GlobalState.WrittenInThisObject = tokenType != JsonToken.StartObject
                && tokenType != JsonToken.StartArray;
            if (tokenType == JsonToken.String)
                return Result("\"" + base.ToString(context).Result + "\"");
            if (tokenType == JsonToken.EndArray)
            {
                context.GlobalState.WrittenEndArray.Add(context.PredicateIdentity);
                return Result("]");
            }
            if (tokenType == JsonToken.EndObject)
                return Result("}");
            if (tokenType == JsonToken.StartArray)
                return Result("[");
            if (tokenType == JsonToken.StartObject)
                return Result("{");
            return base.ToString(context);
        }
    }
}
