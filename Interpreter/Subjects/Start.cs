using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Start : ExpressionElement
    {
        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            var result = context.StartPosition != null && context.StartPosition.SequenceEqual(context.Position);
            return Result(result);
        }

        protected override bool IsStrict()
        {
            return true;
        }
    }
}
