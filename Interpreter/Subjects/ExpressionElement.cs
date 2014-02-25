using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    abstract class ExpressionElement : SyntaxElement
    {
        protected readonly ExpressionElement[] expression;

        public ExpressionElement(params ExpressionElement[] expression)
        {
            this.expression = expression;
        }

        public virtual AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            return AllAppliesAt(context);
        }

        public virtual bool JustAny()
        {
            return expression.Any() && expression.All(element => element.JustAny());
        }

        protected AppliesAtResult AllAppliesAt(AppliesAtContext context)
        {
            var results = expression.Select(element => element.AppliesAt(context));
            return Result(results.All(result => result.Result),
                results
                .SelectMany(result => result.PositiveLog)
                .ToArray());
        }

        protected AppliesAtResult AnyAppliesAt(AppliesAtContext context)
        {
            var results = expression.Select(element => element.AppliesAt(context));
            return Result(results.Any(result => result.Result),
                results
                .SelectMany(result => result.PositiveLog)
                .ToArray());
        }

        protected AppliesAtResult Result(bool result, params Type[] positiveLog)
        {
            if (result)
                return new AppliesAtResult(true,
                    GetType().Enclose()
                    .Concat(positiveLog)
                    .ToArray());
            else
                return new AppliesAtResult(false);
        }
    }
}
