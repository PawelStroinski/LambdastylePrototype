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
        public readonly bool ChildApplies;
        public readonly bool HasOuter;
        public readonly bool AllowNewLine;
        public readonly bool ApplyingItem;
        public readonly bool ApplyingTail;
        public readonly bool ApplyingLiteral;
        public readonly bool ApplyingParent;
        public readonly bool ApplyingOr;
        public readonly bool ApplyingStart;
        public readonly bool ApplyingSpawn;
        public readonly string[] RegExpGroups;
        public readonly Func<Type, bool> AppliedCase;
        public readonly bool DelimitersBefore;
        public readonly PredicateIdentity PredicateIdentity;

        public PredicateContext(GlobalState globalState, PositionStep[] position = null,
            bool childApplies = false, bool hasOuter = false, bool allowNewLine = true,
            bool applyingItem = false, bool applyingTail = false, bool applyingLiteral = false,
            bool applyingParent = false, bool applyingOr = false, bool applyingStart = false,
            bool applyingSpawn = false, string[] regExpGroups = null, Func<Type, bool> appliedCase = null,
            bool delimitersBefore = true, PredicateIdentity predicateIdentity = null)
        {
            GlobalState = globalState;
            Position = position == null ? new PositionStep[0] : position;
            ChildApplies = childApplies;
            HasOuter = hasOuter;
            AllowNewLine = allowNewLine;
            ApplyingItem = applyingItem;
            ApplyingTail = applyingTail;
            ApplyingLiteral = applyingLiteral;
            ApplyingParent = applyingParent;
            ApplyingOr = applyingOr;
            ApplyingStart = applyingStart;
            ApplyingSpawn = applyingSpawn;
            RegExpGroups = regExpGroups;
            AppliedCase = appliedCase;
            DelimitersBefore = delimitersBefore;
            PredicateIdentity = predicateIdentity;
        }

        public PredicateContext Copy(bool hasOuter, bool delimitersBefore, PredicateIdentity predicateIdentity,
            Func<Type, bool> appliedCase)
        {
            return new PredicateContext(
                globalState: GlobalState,
                position: Position,
                childApplies: ChildApplies,
                hasOuter: hasOuter,
                allowNewLine: AllowNewLine,
                applyingItem: ApplyingItem,
                applyingTail: ApplyingTail,
                applyingLiteral: ApplyingLiteral,
                applyingParent: ApplyingParent,
                applyingOr: ApplyingOr,
                applyingStart: ApplyingStart,
                applyingSpawn: ApplyingSpawn,
                regExpGroups: RegExpGroups,
                appliedCase: appliedCase,
                delimitersBefore: delimitersBefore,
                predicateIdentity: predicateIdentity);
        }
    }
}
