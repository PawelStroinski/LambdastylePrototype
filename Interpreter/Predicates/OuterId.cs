using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class OuterId : PredicateElement
    {
        public override string ToString(PositionStep[] position)
        {
            PositionStep propertyName;
            if (position.Last().TokenType == JsonToken.PropertyName)
                propertyName = position.Last();
            else
                if (position.HasPenultimate() && position.Penultimate().TokenType == JsonToken.PropertyName)
                    propertyName = position.Penultimate();
                else
                    return string.Empty;
            return string.Format("\"{0}\": ", propertyName.Value);
        }
    }
}
