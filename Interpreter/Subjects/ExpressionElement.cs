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

        public virtual bool AppliesAt(AppliesAtContext context)
        {
            return expression.All(element => element.AppliesAt(context));
        }

        public virtual bool JustAny()
        {
            return expression.Any() && expression.All(element => element.JustAny());
        }

        public virtual bool HasParent()
        {
            return expression.Any(element => element.HasParent());
        }
    }
}
