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
        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            foreach (var step in context.Position.Reverse().Skip(1))
            {
                if (step.TokenType == JsonToken.EndArray)
                    return Result(false);
                if (step.TokenType == JsonToken.StartArray)
                    return new AppliesAtResult(true, new LogEntry(GetType(), tail: false,
                        position: context.Position.SkipEndWhile(step_ => !step.Equals(step_)).ToArray(),
                        regExpGroups: null));
            }
            return Result(false);
        }
    }
}
