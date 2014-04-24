using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class LiteralishSequence : ExpressionElement
    {
        public LiteralishSequence(params Literalish[] expression) : base(expression) { }

        public override ExpressionElement SubstituteAt(AppliesAtContext context)
        {
            return new RegExp("^" + string.Join(string.Empty,
                expression.Cast<Literalish>().Select(literalish => literalish.ToRegExp())) + "$");
        }
    }
}
