using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Value : ExpressionElement
    {
        public Value(params ExpressionElement[] expression) : base(expression) { }

        public Value(string value) : base(new Literal(value)) { }
    }
}
