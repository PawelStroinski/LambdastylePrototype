using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return elements.All(element => element.AppliesAt(position));
        }

        public override string ToString(PositionStep[] position)
        {
            return string.Join(string.Empty, elements.Select(element => element.ToString(position)));
        }
    }
}
