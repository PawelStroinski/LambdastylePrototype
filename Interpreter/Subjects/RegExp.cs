using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class RegExp : Literal
    {
        readonly string value;

        public RegExp(string value)
        {
            this.value = value;
        }

        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            var position = context.Position;
            var result = position.Any(step => step.Value != null
                && Regex.IsMatch(input: step.Value.ToString(), pattern: value));
            return Result(result);
        }

        public override string ToRegExp()
        {
            return value;
        }
    }
}
