using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Path : ExpressionElement
    {
        public Path(params ExpressionElement[] expression) : base(expression) { }

        public override ExpressionElement ReduceAt(AppliesAtContext context)
        {
            var reduced = new List<ExpressionElement>();
            if (AppliesAt(context, onProgress: (element, context_) => reduced.Add(element.ReduceAt(context_))).Result
                    && reduced.All(element => element is Any))
                return new Any();
            else
                return base.ReduceAt(context);
        }

        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            return AppliesAt(context, (_, __) => { });
        }

        AppliesAtResult AppliesAt(AppliesAtContext context, Action<ExpressionElement, AppliesAtContext> onProgress)
        {
            var positionLength = 1;
            var expressionIndex = 0;
            var position = context.Position;
            var positiveLog = new List<LogEntry>();
            var skippedPosition = new PositionStep[0];
            while (positionLength <= position.Length && expressionIndex < expression.Length)
            {
                var currentPosition = position.Take(positionLength).ToArray();
                var result = expression[expressionIndex].AppliesAt(context.Copy(currentPosition));
                if (result.Result)
                {
                    onProgress(expression[expressionIndex], context.Copy(currentPosition));
                    positiveLog.AddRange(PrefixPosition(log: result.PositiveLog, prefix: skippedPosition));
                    skippedPosition = skippedPosition.Concat(position.Take(positionLength)).ToArray();
                    position = position.Skip(positionLength).ToArray();
                    positionLength = 1;
                    if (expressionIndex == expression.Length - 1)
                    {
                        var tail = position.Any(step => step.TokenType == JsonToken.PropertyName)
                            && !expression.All(element => element is Start);
                        return Result(true, tail: tail, positiveLog: positiveLog.ToArray());
                    }
                    expressionIndex++;
                }
                else
                    if (currentPosition.EndsWith(JsonToken.PropertyName) && expressionIndex > 0)
                        break;
                    else
                        positionLength++;
            }
            return Result(false);
        }

        LogEntry[] PrefixPosition(LogEntry[] log, PositionStep[] prefix)
        {
            return log.Select(entry => entry.Position == null
                ? entry : entry.Copy(prefix.Concat(entry.Position).ToArray())).ToArray();
        }
    }
}
