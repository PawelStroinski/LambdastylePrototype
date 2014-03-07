using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class Predicate : PredicateElement
    {
        readonly PredicateElement[] elements;
        readonly Cases cases = new Cases();
        PredicateIdentity identity = new PredicateIdentity();
        PredicateContext context;

        public Predicate(params PredicateElement[] elements)
        {
            this.elements = elements;
        }

        public Predicate(string raw) : this(new Raw(raw)) { }

        public override bool AppliesAt(PredicateContext context)
        {
            return cases.ApplyTo(context, elements, writing: false).Any(element => element.AppliesAt(context));
        }

        public override ToStringResult ToString(PredicateContext context)
        {
            this.context = context;
            var elementResult = Result(string.Empty);
            var result = string.Empty;
            var seekBy = 0;
            identity = HasOuterId() ? new PredicateIdentity() : identity;
            foreach (var element in cases.ApplyTo(context, elements, writing: true))
            {
                var elementContext = context.Copy(hasOuter: HasOuter(),
                    delimitersBefore: elementResult.DelimitersBeforeInNextOuterValue || !(element is OuterValue),
                    predicateIdentity: identity);
                if (element.AppliesAt(elementContext))
                {
                    elementResult = element.ToString(elementContext);
                    result += elementResult.Result;
                    seekBy += elementResult.SeekBy;
                }
            }
            if (!HasOuter() && context.AllowNewLine && !cases.AppliedCase<CaseOfJoining>()
                    && !cases.AppliedCase<CaseOfOpening>())
                result += Environment.NewLine;
            if (context.GlobalState.ForceSyntax.Value && !context.GlobalState.Written)
                result = InsertStartToken(result);
            var toStringResult = new ToStringResult(result, seekBy: seekBy);
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

        string InsertStartToken(string result)
        {
            var tokenType = Regex.IsMatch(result, Consts.StartsWithPropertyNameRegExp)
                ? JsonToken.StartObject : JsonToken.StartArray;
            var startToken = tokenType == JsonToken.StartObject ? "{" : "[";
            var resultStartsWithStartToken = Regex.IsMatch(input: result, pattern: @"^\s*\" + startToken);
            if (!resultStartsWithStartToken)
            {
                if (result.Trim() != string.Empty)
                    context.GlobalState.WrittenInThisObject = true;
                result = startToken + " " + result;
                context.GlobalState.InsertedStartToken = tokenType;
            }
            return result;
        }

        void ChangeGlobalState(ToStringResult result)
        {
            context.GlobalState.Written = true;
            context.GlobalState.WrittenNewLine = context.GlobalState.WrittenNewLine
                || result.Result.Contains(Environment.NewLine);
            if (result.SeekBy != 0)
                context.GlobalState.Seeked.Add(identity);
        }
    }
}
