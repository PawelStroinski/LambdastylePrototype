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
        public readonly bool IsParent;
        public readonly bool FindParent;

        public AppliesAtContext(PositionStep[] position, bool strict, PositionStep[] startPosition, bool isParent,
            bool findParent)
        {
            Position = position;
            Strict = strict;
            StartPosition = startPosition;
            IsParent = isParent;
            FindParent = findParent;
        }

        public AppliesAtContext Copy(PositionStep[] position)
        {
            return new AppliesAtContext(position: position, strict: Strict, startPosition: StartPosition,
                isParent: IsParent, findParent: FindParent);
        }

        public AppliesAtContext Copy(bool findParent)
        {
            return new AppliesAtContext(position: Position, strict: Strict, startPosition: StartPosition,
                isParent: IsParent, findParent: findParent);
        }
    }
}
