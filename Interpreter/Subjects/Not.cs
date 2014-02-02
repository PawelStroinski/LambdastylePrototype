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
    }
}
