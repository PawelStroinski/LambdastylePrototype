using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    struct AppliesAtContext
    {
        public readonly PositionStep[] Position;
        public readonly bool Strict;

        public AppliesAtContext(PositionStep[] position, bool strict)
        {
            Position = position;
            Strict = strict;
        }
    }
}
