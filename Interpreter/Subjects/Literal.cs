using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Literal : Literalish
    {
        readonly object value;

        public Literal(string value)
        {
            this.value = value;
        }

        public Literal(Int64 value)
        {
            this.value = value;
        }

        public Literal(bool value)
        {
            this.value = value;
        }

        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            var position = context.Position;
            var result = position.Any(step => value.Equals(step.Value));
            return Result(result);
        }

        public override string ToRegExp()
        {
            return Regex.Escape(value.ToString());
        }

        protected Literal() { }

        protected override bool IsStrict()
        {
            return true;
        }
    }
}
