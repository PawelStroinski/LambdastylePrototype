using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    struct AppliesAtResult
    {
        public readonly bool Result;
        public readonly Type[] PositiveLog;

        public AppliesAtResult(bool result, params Type[] positiveLog)
        {
            Result = result;
            PositiveLog = positiveLog;
        }
    }
}
