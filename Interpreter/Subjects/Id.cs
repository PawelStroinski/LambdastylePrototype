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
            var propertyNames = position.Where(item => item.TokenType == JsonToken.PropertyName).ToArray();
            if (propertyNames.Length > 1)
            {
                var lastPropertyName = propertyNames.Skip(propertyNames.Length - 1).ToArray();
                var propertyNamesWithoutLast = propertyNames.Take(propertyNames.Length - 1).ToArray();
                var result = AnyAppliesAt(new AppliesAtContext(lastPropertyName, context.Strict));
                if (result.Result)
                    return result;
                return AnyAppliesAt(new AppliesAtContext(propertyNamesWithoutLast, context.Strict), tail: true);
            }
            else
                return AnyAppliesAt(new AppliesAtContext(propertyNames, context.Strict));
        }
    }
}
