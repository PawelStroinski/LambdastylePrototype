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
            var propertyNames = position.Where(item => item.TokenType == JsonToken.PropertyName).ToArray();
            if (propertyNames.Length > 1)
            {
                var lastPropertyName = propertyNames.Skip(propertyNames.Length - 1).ToArray();
                var propertyNamesWithoutLast = propertyNames.Take(propertyNames.Length - 1).ToArray();
                var result = AnyAppliesAt(context.Copy(lastPropertyName));
                if (result.Result)
                    return result;
                else
                    return AnyAppliesAt(context.Copy(propertyNamesWithoutLast), tail: true);
            }
            else
                return AnyAppliesAt(context.Copy(propertyNames));
        }

        protected override bool IsStrict()
        {
            return true;
        }
    }
}
