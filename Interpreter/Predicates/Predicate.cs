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
        PredicateContext context;

        public Predicate(params PredicateElement[] elements)
        {
            this.elements = elements;
        }

        public Predicate(string raw) : this(new Raw(raw)) { }

        public override bool AppliesAt(PredicateContext context)
        {
            return elements.Any(element => element.AppliesAt(context));
        }

        public override ToStringResult ToString(PredicateContext context)
        {
            this.context = context;
            var joining = new Joining(context, elements);
            var elementResult = Result(string.Empty);
            var result = string.Empty;
            foreach (var element in joining.JoinElements()
                .Where(element => element.AppliesAt(context)))
            {
                var elementContext = context.Copy(hasOuter: HasOuter(),
                    delimitersBefore: elementResult.DelimitersBeforeInNextOuterValue || !(element is OuterValue));
                elementResult = element.ToString(elementContext);
                result += elementResult.Result;
            }
            if (!HasOuter() && context.AllowNewLine && !joining.IsJoining)
                result += Environment.NewLine;
            if (context.GlobalState.ForceSyntax.Value && !context.GlobalState.Written)
                result = InsertStartToken(result);
            context.GlobalState.Written = true;
            return Result(result);
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
            var tokenType = context.Position.Last(step => step.TokenType == JsonToken.StartObject
                || step.TokenType == JsonToken.StartArray).TokenType;
            if (HasApplicableOuterId())
                tokenType = JsonToken.StartObject;
            var startToken = tokenType == JsonToken.StartObject ? "{" : "[";
            var resultStartsWithStartToken = Regex.IsMatch(input: result, pattern: @"^\s*\" + startToken);
            if (!resultStartsWithStartToken)
            {
                result = startToken + " " + result;
                context.GlobalState.InsertedStartToken = tokenType;
            }
            return result;
        }

        bool HasApplicableOuterId()
        {
            return elements.Any(element => element is OuterId
                && element.AppliesAt(context));
        }
    }
}
