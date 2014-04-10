using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Null : Literal
    {
        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            var position = context.Position;
            var result = position.Any(step => step.TokenType == JsonToken.Null);
            return Result(result);
        }
    }
}
