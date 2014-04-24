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

        public override ExpressionElement ReduceAt(AppliesAtContext context)
        {
            var reduced = expression.Select(element => element.ReduceAt(context)).ToArray();
            if (reduced.Any(element => element is Any))
                if (context.FindParent)
                {
                    if (!reduced.Any(element => element.HasParent()))
                        return new Any();
                }
                else
                    return new Any();
            return RecreateWithExpression(reduced);
        }

        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            return AnyAppliesAt(context);
        }
    }
}
