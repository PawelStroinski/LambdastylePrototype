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
            var elements = cases.ApplyTo(new CaseContext(ContextForCases(), this.elements, writing: false));
            return elements.Any(element => element.AppliesAt(context));
        }

        public override ToStringResult ToString(PredicateContext context)
        {
            this.context = context;
            identity = HasOuterId() ? new PredicateIdentity() : identity;
            var result = string.Empty;
            var seekBy = 0;
            var delimitersBefore = true;
            var previousElement = (PredicateElement)null;
            var elements = cases.ApplyTo(new CaseContext(ContextForCases(), this.elements, writing: true));
            foreach (var element in elements)
            {
                var elementContext = context.Copy(hasOuter: HasOuter(),
                    delimitersBefore: delimitersBefore || (previousElement is OuterId && element is OuterValue),
                    predicateIdentity: identity);
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
                && !cases.AppliedCase<Tail>())
            {
                result += Environment.NewLine;
                context.GlobalState.AddedNewLine.Add(identity);
            }
            if (context.GlobalState.ForceSyntax.Value && !context.GlobalState.Written)
                result = InsertStartToken(result);
            var toStringResult = new ToStringResult(result, seekBy: seekBy, rewind: Rewind());
            ChangeGlobalState(toStringResult);
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

        bool HasOuter()
        {
            return HasOuterValue() || HasOuterId();
        }

        PredicateContext ContextForCases()
        {
            return context.Copy(hasOuter: HasOuter(), delimitersBefore: false, predicateIdentity: identity);
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
            return context.ApplyingLiteral && !HasOuterId() && !cases.AppliedCase<Wrapping>();
        }

        void ChangeGlobalState(ToStringResult result)
        {
            context.GlobalState.Written = true;
            context.GlobalState.WrittenNewLine = context.GlobalState.WrittenNewLine
                || result.Result.Contains(Environment.NewLine);
            if (result.SeekBy != 0)
                context.GlobalState.Seeked.Add(identity);
            context.GlobalState.LastApplyingTail = context.ApplyingTail;
        }
    }
}
