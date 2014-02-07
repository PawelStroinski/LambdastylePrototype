using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Item : ExpressionElement
    {
        public override bool AppliesAt(PositionStep[] position, bool strict)
        {
            foreach (var step in position.Reverse().Skip(1))
            {
                if (step.TokenType == JsonToken.EndArray)
                    return false;
                if (step.TokenType == JsonToken.StartArray)
                    return true;
            }
            return false;
        }
    }
}
