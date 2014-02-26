using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates
{
    abstract class ValueBase : PredicateElement
    {
        public override ToStringResult ToString(PredicateContext context)
        {
            var tokenType = context.Position.Last().TokenType;
            var value = context.Position.Last().Value;
            if (tokenType == JsonToken.Null)
                return Result("null");
            if (tokenType == JsonToken.Undefined)
                return Result("undefined");
            if (tokenType == JsonToken.Boolean)
                return Result(value.ToString().ToLowerInvariant());
            return Result(value.ToString());
        }
    }
}
