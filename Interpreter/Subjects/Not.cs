using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Not : ExpressionElement
    {
        public Not(params ExpressionElement[] expression) : base(expression) { }

        public override ExpressionElement ReduceAt(AppliesAtContext context)
        {
            if (expression.Any() && context.Position.LastTokenType().IsEnd())
                return new Any();
            if (AppliesAt(context).Result)
                return this;
            else
                return new Not();
        }

        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            var baseResult = base.AppliesAt(context);
            return Result(!baseResult.Result);
        }
    }
}
