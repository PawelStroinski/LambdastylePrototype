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
        public readonly PositionStep[] StartPosition;

        public AppliesAtContext(PositionStep[] position, bool strict, PositionStep[] startPosition)
        {
            Position = position;
            Strict = strict;
            StartPosition = startPosition;
        }

        public AppliesAtContext Copy(PositionStep[] position)
        {
            return new AppliesAtContext(position: position, strict: Strict, startPosition: StartPosition);
        }
    }
}
