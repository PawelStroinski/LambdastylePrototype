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

        public Predicate(params PredicateElement[] elements)
        {
            this.elements = elements;
        }

        public Predicate(string raw) : this(new Raw(raw)) { }

        public override bool AppliesAt(PositionStep[] position)
        {
            return elements.Any(element => element.AppliesAt(position));
        }

        public override string ToString(PositionStep[] position, GlobalState state)
        {
            var result = string.Join(string.Empty, elements
                .Where(element => element.AppliesAt(position))
                .Select(element => element.ToString(position, state)));
            if (!HasOuterValue() && !HasOuterId())
                result += Environment.NewLine;
            if (state.ProtectSyntax.Value && !state.Written)
                result = InsertStartToken(position: position, state: state, result: result);
            state.Written = true;
            return result;
        }

        public bool HasOuterValue()
        {
            return elements.Any(element => element is OuterValue);
        }

        public bool HasOuterId()
        {
            return elements.Any(element => element is OuterId);
        }

        string InsertStartToken(PositionStep[] position, GlobalState state, string result)
        {
            var tokenType = position.Last(step => step.TokenType == JsonToken.StartObject 
                || step.TokenType == JsonToken.StartArray).TokenType;
            var startToken = tokenType == JsonToken.StartObject ? "{" : "[";
            var resultStartsWithStartToken = Regex.IsMatch(input: result, pattern: @"\s*\" + startToken);
            if (!resultStartsWithStartToken)
            {
                result = startToken + " " + result;
                state.InsertedStartToken = tokenType;
            }
            return result;
        }
    }
}
