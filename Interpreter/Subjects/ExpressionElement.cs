﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    abstract class ExpressionElement : SyntaxElement
    {
        protected readonly ExpressionElement[] expression;

        public ExpressionElement(params ExpressionElement[] expression)
        {
            this.expression = expression;
        }

        public virtual AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            if (context.Strict && !AllStrict())
                return Result(false);
            var substitute = Substitute(context);
            return substitute.AllAppliesAt(context);
        }

        public virtual ExpressionElement ReduceAt(AppliesAtContext context)
        {
            var reduced = Substitute(context).expression.Select(element => element.ReduceAt(context)).ToArray();
            if (reduced.All(element => element is Any) && AppliesAt(context).Result)
                return new Any();
            else
                return RecreateWithExpression(reduced);
        }

        public virtual bool JustAny()
        {
            return expression.Any() && expression.All(element => element.JustAny());
        }

        public virtual bool HasParent()
        {
            return expression.Any(element => element.HasParent());
        }

        protected AppliesAtResult AllAppliesAt(AppliesAtContext context)
        {
            var results = expression.Select(element => element.AppliesAt(context)).ToArray();
            return Result(results.All(result => result.Result),
                results
                .SelectMany(result => result.PositiveLog)
                .ToArray());
        }

        protected AppliesAtResult AnyAppliesAt(AppliesAtContext context, bool tail = false)
        {
            var results = expression.Select(element => element.AppliesAt(context)).ToArray();
            return Result(results.Any(result => result.Result), tail: tail,
                positiveLog: results
                .SelectMany(result => result.PositiveLog)
                .ToArray());
        }

        protected AppliesAtResult Result(bool result, params LogEntry[] positiveLog)
        {
            return Result(result: result, tail: false, positiveLog: positiveLog);
        }

        protected AppliesAtResult Result(bool result, bool tail, params LogEntry[] positiveLog)
        {
            if (result)
                return new AppliesAtResult(true,
                    new LogEntry(GetType(), tail).Enclose()
                    .Concat(positiveLog)
                    .ToArray());
            else
                return new AppliesAtResult(false);
        }

        protected virtual bool IsStrict()
        {
            return true;
        }

        protected virtual ExpressionElement Substitute(AppliesAtContext context)
        {
            var substitute = SubstituteParent(context)
                .Select(element => element.Substitute(context)).ToArray();
            return RecreateWithExpression(substitute);
        }

        protected ExpressionElement RecreateWithExpression(ExpressionElement[] expression)
        {
            if (this.expression.SequenceEqual(expression))
                return this;
            else
                return (ExpressionElement)Activator.CreateInstance(this.GetType(), expression);
        }

        ExpressionElement[] SubstituteParent(AppliesAtContext context)
        {
            return context.IsParent ? SubstituteParentWhenIsParent() : SubstituteParentWhenIsNotParent(context);
        }

        ExpressionElement[] SubstituteParentWhenIsParent()
        {
            if (expression.Length == 1 && expression.First() is Parent)
                return new Any().Enclose().ToArray();
            else
                return expression.Select(element => element is Parent ? new Start() : element).ToArray();
        }

        ExpressionElement[] SubstituteParentWhenIsNotParent(AppliesAtContext context)
        {
            if (expression.Any(element => element is Parent))
                if (context.FindParent)
                    return expression.Select(element => element is Parent ? element : new Any()).ToArray();
                else
                    return expression.Select(element => element is Parent ? new Not() : element).ToArray();
            else
                return expression;
        }

        bool AllStrict()
        {
            return IsStrict() && expression.All(element => element.AllStrict());
        }
    }
}
