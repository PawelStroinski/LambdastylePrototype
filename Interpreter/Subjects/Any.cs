using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Any : Literalish
    {
        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            var result = !context.Position.All(step => step.TokenType.IsEnd());
            return Result(result);
        }

        public override bool JustAny()
        {
            return true;
        }

        public override string ToRegExp()
        {
            return "*";
        }
    }
}
