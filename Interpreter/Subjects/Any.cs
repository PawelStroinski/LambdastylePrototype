using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Any : Literal
    {
        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            return Result(true);
        }

        public override bool JustAny()
        {
            return true;
        }
    }
}
