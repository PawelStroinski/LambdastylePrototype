using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Or : ExpressionElement
    {
        public Or(ExpressionElement left, ExpressionElement right) : base(left, right) { }
    }
}
