﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Path : ExpressionElement
    {
        public Path(params ExpressionElement[] expression) : base(expression) { }

        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            var positionLength = 1;
            var expressionIndex = 0;
            var position = context.Position;
            var positiveLog = new List<LogEntry>();
            while (positionLength <= position.Length && expressionIndex < expression.Length)
            {
                var currentPosition = position.Take(positionLength).ToArray();
                var result = expression[expressionIndex].AppliesAt(new AppliesAtContext(currentPosition));
                if (result.Result)
                {
                    positiveLog.AddRange(result.PositiveLog);
                    if (expressionIndex == expression.Length - 1)
                        return Result(true, positiveLog.ToArray());
                    expressionIndex++;
                    position = position.Skip(positionLength).ToArray();
                    positionLength = 1;
                }
                else
                    positionLength++;
            }
            return Result(false);
        }
    }
}
