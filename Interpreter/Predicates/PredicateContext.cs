using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates
{
    struct PredicateContext
    {
        public readonly GlobalState GlobalState;
        public readonly PositionStep[] Position;
        public readonly bool HasOuter;
        public readonly bool AllowNewLine;
        public readonly bool ApplyingItem;
        public readonly bool ApplyingTail;
        public readonly bool ApplyingLiteral;
        public readonly bool ApplyingParent;
        public readonly bool DelimitersBefore;
        public readonly PredicateIdentity PredicateIdentity;

        public PredicateContext(GlobalState globalState, PositionStep[] position = null,
            bool hasOuter = false, bool allowNewLine = true, bool applyingItem = false,
            bool applyingTail = false, bool applyingLiteral = false, bool applyingParent = false,
            bool delimitersBefore = true, PredicateIdentity predicateIdentity = null)
        {
            GlobalState = globalState;
            Position = position == null ? new PositionStep[0] : position;
            HasOuter = hasOuter;
            AllowNewLine = allowNewLine;
            ApplyingItem = applyingItem;
            ApplyingTail = applyingTail;
            ApplyingLiteral = applyingLiteral;
            ApplyingParent = applyingParent;
            DelimitersBefore = delimitersBefore;
            PredicateIdentity = predicateIdentity;
        }

        public PredicateContext Copy(bool hasOuter, bool delimitersBefore, PredicateIdentity predicateIdentity)
        {
            return new PredicateContext(
                globalState: GlobalState,
                position: Position,
                hasOuter: hasOuter,
                allowNewLine: AllowNewLine,
                applyingItem: ApplyingItem,
                applyingTail: ApplyingTail,
                applyingLiteral: ApplyingLiteral,
                applyingParent: ApplyingParent,
                delimitersBefore: delimitersBefore,
                predicateIdentity: predicateIdentity);
        }
    }
}
