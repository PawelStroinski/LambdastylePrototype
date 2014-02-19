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
        public readonly bool InParentOnly;

        public AppliesAtContext(PositionStep[] position, bool strict)
        {
            Position = position;
            Strict = strict;
            InParentOnly = false;
        }

        public AppliesAtContext CopyAsInParentOnly()
        {
            return new AppliesAtContext(
                position: Position,
                strict: Strict,
                inParentOnly: true);
        }

        AppliesAtContext(PositionStep[] position, bool strict, bool inParentOnly)
            : this(position, strict)
        {
            InParentOnly = inParentOnly;
        }
    }
}
