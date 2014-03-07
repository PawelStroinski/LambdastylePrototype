using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class Override : PredicateElement
    {
        readonly PredicateElement overriden;
        readonly Func<PredicateContext, bool> appliesAt;
        readonly Func<PredicateContext, ToStringResult> toString;

        public Override(PredicateElement overriden, Func<PredicateContext, bool> appliesAt = null,
            Func<PredicateContext, ToStringResult> toString = null)
        {
            this.overriden = overriden;
            this.appliesAt = appliesAt;
            this.toString = toString;
        }

        public override bool AppliesAt(PredicateContext context)
        {
            if (appliesAt == null)
                return overriden.AppliesAt(context);
            else
                return appliesAt(context);
        }

        public override ToStringResult ToString(PredicateContext context)
        {
            if (toString == null)
                return overriden.ToString(context);
            else
                return toString(context);
        }
    }
}
