using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Path : ExpressionElement
    {
        public Path(params ExpressionElement[] expression) : base(expression) { }

        public override bool AppliesAt(PositionStep[] position)
        {
            var positionLength = 1;
            var expressionIndex = 0;
            while (positionLength <= position.Length && expressionIndex < expression.Length)
            {
                var currentPosition = position.Take(positionLength).ToArray();
                if (expression[expressionIndex].AppliesAt(currentPosition))
                {
                    if (expressionIndex == expression.Length - 1)
                        return true;
                    expressionIndex++;
                    position = position.Skip(positionLength).ToArray();
                    positionLength = 1;
                }
                else
                    positionLength++;
            }
            return false;
        }
    }
}
