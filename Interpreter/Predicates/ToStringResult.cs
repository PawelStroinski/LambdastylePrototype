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
        public readonly int SeekBy;

        public ToStringResult(string result, bool delimitersBeforeInNextOuterValue = true, int seekBy = 0)
        {
            Result = result;
            DelimitersBeforeInNextOuterValue = delimitersBeforeInNextOuterValue;
            SeekBy = seekBy;
        }

        public ToStringResult Copy(string result, int seekBy = 0)
        {
            return new ToStringResult(
                result: result,
                delimitersBeforeInNextOuterValue: DelimitersBeforeInNextOuterValue,
                seekBy: seekBy);
        }
    }
}
