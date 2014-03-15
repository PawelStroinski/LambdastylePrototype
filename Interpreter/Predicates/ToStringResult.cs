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
        public readonly bool Rewind;

        public ToStringResult(string result, bool hasDelimitersBefore, int seekBy, bool rewind)
        {
            Result = result;
            HasDelimitersBefore = hasDelimitersBefore;
            SeekBy = seekBy;
            Rewind = rewind;
        }

        public ToStringResult(string result, bool hasDelimitersBefore, int seekBy)
            : this(result: result, hasDelimitersBefore: hasDelimitersBefore, seekBy: seekBy, rewind: false)
        {
        }

        public ToStringResult(string result, int seekBy, bool rewind)
            : this(result: result, hasDelimitersBefore: false, seekBy: seekBy, rewind: rewind)
        {
        }
    }
}
