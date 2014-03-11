using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Subject : ExpressionElement
    {
        public Subject(params ExpressionElement[] expression) : base(expression) { }

        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            if (context.Position.EndsWith(JsonToken.PropertyName))
                return Result(false);
            else
                return base.AppliesAt(context);
        }
    }
}
