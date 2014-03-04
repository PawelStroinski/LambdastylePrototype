using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Or : ExpressionElement
    {
        public Or(params ExpressionElement[] expression) : base(expression) { }

        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            return AnyAppliesAt(context);
        }
    }
}
