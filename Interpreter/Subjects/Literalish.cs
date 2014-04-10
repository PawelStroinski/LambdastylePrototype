using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    abstract class Literalish : ExpressionElement
    {
        public abstract string ToRegExp();
    }
}
