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

        public override string ToString(ToStringContext context)
        {
            context = context.Copy(HasOuter());
            var result = string.Join(string.Empty, elements
                .Where(element => element.AppliesAt(context.Position))
                .Select(element => element.ToString(context)));
            if (!HasOuter())
                result += Environment.NewLine;
            if (context.GlobalState.ForceSyntax.Value && !context.GlobalState.Written)
                result = InsertStartToken(context, result);
            context.GlobalState.Written = true;
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

        bool HasOuter()
        {
            return HasOuterValue() || HasOuterId();
        }

        string InsertStartToken(ToStringContext context, string result)
        {
            var tokenType = context.Position.Last(step => step.TokenType == JsonToken.StartObject 
                || step.TokenType == JsonToken.StartArray).TokenType;
            var startToken = tokenType == JsonToken.StartObject ? "{" : "[";
            var resultStartsWithStartToken = Regex.IsMatch(input: result, pattern: @"\s*\" + startToken);
            if (!resultStartsWithStartToken)
            {
                result = startToken + " " + result;
                context.GlobalState.InsertedStartToken = tokenType;
            }
            return result;
        }
    }
}
