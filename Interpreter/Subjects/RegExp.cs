using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class RegExp : Literal
    {
        readonly object value;

        public RegExp(string value)
        {
            this.value = value;
        }
    }
}
