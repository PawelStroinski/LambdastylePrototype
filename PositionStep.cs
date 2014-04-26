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
                && object.Equals(Value, compared.Value)
                && (ItemIndex == -1 || compared.ItemIndex == -1 || ItemIndex == compared.ItemIndex);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 3;
                hash = hash * 5 + TokenType.GetHashCode();
                if (Value != null)
                    hash = hash * 5 + Value.GetHashCode();
                return hash;
            }
        }

        public PositionStep Copy(int itemIndex)
        {
            return new PositionStep(
                tokenType: TokenType,
                value: Value,
                delimitersBefore: DelimitersBefore,
                delimitersAfter: DelimitersAfter,
                itemIndex: itemIndex);
        }
    }
}
