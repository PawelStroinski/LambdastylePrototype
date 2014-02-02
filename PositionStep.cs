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

        public PositionStep(JsonToken tokenType, object value)
        {
            TokenType = tokenType;
            Value = value;
        }
    }
}
