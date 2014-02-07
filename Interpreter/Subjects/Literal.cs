using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Literal : ExpressionElement
    {
        readonly object value;

        public Literal(string value)
        {
            this.value = value;
        }

        public Literal(int value)
        {
            this.value = value;
        }

        public Literal(bool value)
        {
            this.value = value;
        }

        public override bool AppliesAt(PositionStep[] position, bool strict)
        {
            return position.Any(step => value.Equals(step.Value));
        }

        protected Literal() { }
    }
}
