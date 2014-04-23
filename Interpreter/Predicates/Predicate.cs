using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter.Predicates.Cases;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class Predicate : PredicateElement
    {
        readonly PredicateElement[] elements;
        readonly AllCases cases = new AllCases();
        PredicateIdentity identity = new PredicateIdentity();
        PredicateContext context;

        public Predicate(params PredicateElement[] elements)
        {
            this.elements = elements;
        }

        public Predicate(string raw) : this(new Raw(raw)) { }

        public override bool AppliesAt(PredicateContext context)
        {
            this.context = context;
            SetIdentityAndScope();
            var elements = cases.ApplyTo(new CaseContext(GetContext(), this.elements, writing: false));
            return elements.Any(element => element.AppliesAt(context));
        }

        public override ToStringResult ToString(PredicateContext context)
        {
            this.context = context;
            SetIdentityAndScope();
            var result = string.Empty;
            var seekBy = 0;
            var delimitersBefore = true;
            var previousElement = (PredicateElement)null;
            var elements = cases.ApplyTo(new CaseContext(GetContext(), this.elements, writing: true));
            foreach (var element in elements)
            {
                var elementContext = context.Copy(hasOuter: HasOuter(),
                    delimitersBefore: delimitersBefore || (previousElement is OuterId && element is OuterValue),
                    predicateIdentity: identity, appliedCase: cases.AppliedCase);
                if (element.AppliesAt(elementContext))
                {
                    var elementResult = element.ToString(elementContext);
                    if ((element is OuterValue || element is Raw) && elementResult.HasDelimitersBefore)
                        delimitersBefore = false;
                    result += elementResult.Result;
                    seekBy += elementResult.SeekBy;
                }
                previousElement = element;
            }
            if (context.AllowNewLine && !HasOuter() && !cases.AppliedCase<Joining>() && !cases.AppliedCase<Opening>()
                    && !cases.AppliedCase<Tail>() && !context.GlobalState.ForceSyntax.Value)
                if (context.ApplyingSpawn)
                {
                    if (!context.GlobalState.WrittenInThisObject)
                        context.GlobalState.WriteDeferredNewLine = true;
                }
                else
                {
                    result += Environment.NewLine;
                    context.GlobalState.AddedNewLine.Add(identity);
                }
            if (context.GlobalState.ForceSyntax.Value && !context.GlobalState.Written)
                result = InsertStartToken(result);
            var toStringResult = new ToStringResult(result, seekBy: seekBy, rewind: Rewind());
            ChangeGlobalState(toStringResult);
            WriteDebug(toStringResult);
            return toStringResult;
        }

        public bool HasOuterValue()
        {
            return elements.Any(element => element is OuterValue);
        }

        public bool HasOuterId()
        {
            return elements.Any(element => element is OuterId);
        }

        public bool HasValue()
        {
            return elements.Any(element => element is ValueBase);
        }

        bool HasOuter()
        {
            return HasOuterValue() || HasOuterId();
        }

        bool HasInnerValue()
        {
            return elements.Any(element => element is InnerValue);
        }

        void SetIdentityAndScope()
        {
            if (HasOuterId() && !HasInnerValue() && !context.ApplyingStart)
                identity = new PredicateIdentity();
            context.GlobalState.PredicateScope.Change(GetContext());
        }

        PredicateContext GetContext()
        {
            return context.Copy(hasOuter: HasOuter(), delimitersBefore: false, predicateIdentity: identity,
                appliedCase: cases.AppliedCase);
        }

        string InsertStartToken(string result)
        {
            var resultStartsWithStartToken = Regex.IsMatch(input: result, pattern: Consts.StartsWithStartObject)
                || Regex.IsMatch(input: result, pattern: Consts.StartsWithStartArray);
            if (!resultStartsWithStartToken)
            {
                if (result.Trim() != string.Empty
                        && !Regex.IsMatch(input: result, pattern: Consts.EndsWithStartObject)
                        && !Regex.IsMatch(input: result, pattern: Consts.EndsWithEndObject))
                    context.GlobalState.WrittenInThisObject = true;
                var tokenType = Regex.IsMatch(input: result, pattern: Consts.StartsWithPropertyName)
                    ? JsonToken.StartObject : JsonToken.StartArray;
                var token = tokenType == JsonToken.StartObject ? "{" : "[";
                result = token + " " + result;
                context.GlobalState.InsertedStartToken = tokenType;
            }
            return result;
        }

        bool Rewind()
        {
            if (context.ApplyingOr)
                return true;
            if (context.ApplyingStart && context.GlobalState.WrittenInThisObject)
                return false;
            return context.ApplyingLiteral && !HasOuterId() && !HasRawPropertyName() && !cases.AppliedCase<Wrapping>();
        }

        void ChangeGlobalState(ToStringResult result)
        {
            context.GlobalState.Written = true;
            context.GlobalState.WrittenNewLine = context.GlobalState.WrittenNewLine
                || result.Result.Contains(Environment.NewLine);
            if (result.SeekBy != 0)
                context.GlobalState.Seeked.Add(identity);
            context.GlobalState.LastApplyingTail = context.ApplyingTail;
            context.GlobalState.PredicateScope.SetWritten();
            context.GlobalState.WrittenPredicate.Add(identity);
        }

        void WriteDebug(ToStringResult toStringResult)
        {
            Extension.WriteDebugLine(toStringResult.ToString() + "   " + cases.ToString() + Environment.NewLine);
        }

        bool HasRawPropertyName()
        {
            return elements.OfType<Raw>()
                .Any(raw => Regex.IsMatch(input: raw.ToString(context).Result, pattern: Consts.PropertyName));
        }
    }
}
