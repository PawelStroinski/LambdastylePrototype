using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Equals : ExpressionElement
    {
        public Equals(ExpressionElement left, ExpressionElement right) : base(left, right) { }

        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            var tokenType = context.Position.LastTokenType();
            if (tokenType.IsValue() || tokenType.IsStart())
                return base.AppliesAt(context);
            else
                return Result(false);
        }
    }
}
