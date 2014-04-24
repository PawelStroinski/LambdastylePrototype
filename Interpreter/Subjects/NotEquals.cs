using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class NotEquals : ExpressionElement
    {
        public NotEquals(ExpressionElement left, ExpressionElement right) : base(left, right) { }

        public override ExpressionElement SubstituteAt(AppliesAtContext context)
        {
            return new And(new Equals(expression[0], new Any()), new Not(new Equals(expression[0], expression[1])));
        }
    }
}
