﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Predicates
{
    abstract class PredicateElement : SyntaxElement
    {
        public virtual bool AppliesAt(PredicateContext context)
        {
            return true;
        }

        public abstract ToStringResult ToString(PredicateContext context);

        protected ToStringResult Result(string result)
        {
            return new ToStringResult(result, delimitersBeforeInNextOuterValue: true);
        }
    }
}
