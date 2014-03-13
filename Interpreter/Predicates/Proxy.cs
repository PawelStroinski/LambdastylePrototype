using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class Proxy : PredicateElement
    {
        readonly PredicateElement proxied;
        readonly Func<bool, PredicateContext, bool> appliesAt;
        readonly Func<ToStringResult, PredicateContext, ToStringResult> toString;

        public Proxy(PredicateElement proxied, Func<bool, PredicateContext, bool> appliesAt = null,
            Func<ToStringResult, PredicateContext, ToStringResult> toString = null)
        {
            this.proxied = proxied;
            this.appliesAt = appliesAt;
            this.toString = toString;
        }

        public override bool AppliesAt(PredicateContext context)
        {
            var result = proxied.AppliesAt(context);
            if (appliesAt == null)
                return result;
            else
                return appliesAt(result, context);
        }

        public override ToStringResult ToString(PredicateContext context)
        {
            var result = proxied.ToString(context);
            if (toString == null)
                return result;
            else
                return toString(result, context);
        }
    }
}
