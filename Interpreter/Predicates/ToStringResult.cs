using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates
{
    struct ToStringResult
    {
        public readonly string Result;
        public readonly bool DelimitersBeforeInNextOuterValue;

        public ToStringResult(string result, bool delimitersBeforeInNextOuterValue)
        {
            Result = result;
            DelimitersBeforeInNextOuterValue = delimitersBeforeInNextOuterValue;
        }

        public ToStringResult Copy(string result)
        {
            return new ToStringResult(
                result: result,
                delimitersBeforeInNextOuterValue: DelimitersBeforeInNextOuterValue);
        }
    }
}
