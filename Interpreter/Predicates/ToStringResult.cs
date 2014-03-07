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
        public readonly bool HasDelimitersBefore;
        public readonly int SeekBy;

        public ToStringResult(string result, bool hasDelimitersBefore = true, int seekBy = 0)
        {
            Result = result;
            HasDelimitersBefore = hasDelimitersBefore;
            SeekBy = seekBy;
        }

        public ToStringResult Copy(string result, bool hasDelimitersBefore = true, int seekBy = 0)
        {
            return new ToStringResult(
                result: result,
                hasDelimitersBefore: HasDelimitersBefore || hasDelimitersBefore,
                seekBy: seekBy);
        }
    }
}
