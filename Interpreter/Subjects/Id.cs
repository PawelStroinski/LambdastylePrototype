using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Id : ExpressionElement
    {
        public Id(params ExpressionElement[] expression) : base(expression) { }

        public Id(string id) : base(new Literal(id)) { }

        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            var position = context.Position;
            if (context.Strict)
                position = position.Take(position.Count() - 1).ToArray();
            position = position.Where(item => item.TokenType == JsonToken.PropertyName).ToArray();
            return AnyAppliesAt(new AppliesAtContext(position, context.Strict));
        }
    }
}
