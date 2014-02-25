using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Literal : ExpressionElement
    {
        readonly object value;

        public Literal(string value)
        {
            this.value = value;
        }

        public Literal(Int64 value)
        {
            this.value = value;
        }

        public Literal(bool value)
        {
            this.value = value;
        }

        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            var position = context.Position;
            var result = position.Any() && value.Equals(position.Last().Value);
            return Result(result);
        }

        protected Literal() { }
    }
}
