using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class ShortOr : ExpressionElement
    {
        public ShortOr(ExpressionElement left, ExpressionElement right) : base(left, right) { }

        public override ExpressionElement SubstituteAt(AppliesAtContext context)
        {
            var left = expression[0];
            var right = expression[1];
            right = new And(new Path(new Parent(new And(right, new Not(left)))), right);
            return new Or(left, right);
        }
    }
}
