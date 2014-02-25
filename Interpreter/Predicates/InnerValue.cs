using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class InnerValue : ValueBase
    {
        public override bool AppliesAt(PredicateContext context)
        {
            var tokenType = context.Position.Last().TokenType;
            return tokenType.IsValue();
        }
    }
}
