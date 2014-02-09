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

        public PositionStep(JsonToken tokenType, object value, string delimitersBefore, string delimitersAfter)
        {
            TokenType = tokenType;
            Value = value;
            DelimitersBefore = delimitersBefore;
            DelimitersAfter = delimitersAfter;
        }
    }
}
