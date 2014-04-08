using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype
{
    struct PositionStep
    {
        public readonly JsonToken TokenType;
        public readonly object Value;
        public readonly string DelimitersBefore;
        public readonly string DelimitersAfter;
        public readonly int ItemIndex;

        public PositionStep(JsonToken tokenType, object value, string delimitersBefore, string delimitersAfter,
            int itemIndex)
        {
            TokenType = tokenType;
            Value = value;
            DelimitersBefore = delimitersBefore;
            DelimitersAfter = delimitersAfter;
            ItemIndex = itemIndex;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is PositionStep))
                return false;
            var compared = (PositionStep)obj;
            return TokenType == compared.TokenType
                && object.Equals(Value, compared.Value);
        }
    }
}
