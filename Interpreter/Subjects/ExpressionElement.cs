using System;
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
            var substitute = Substitute(context);
            return substitute.AllAppliesAt(context);
        }

        public virtual bool JustAny()
        {
            return expression.Any() && expression.All(element => element.JustAny());
        }

        protected AppliesAtResult AllAppliesAt(AppliesAtContext context)
        {
            if (RejectByStrictness(context))
                return Result(false);
            var results = expression.Select(element => element.AppliesAt(context)).ToArray();
            return Result(results.All(result => result.Result),
                results
                .SelectMany(result => result.PositiveLog)
                .ToArray());
        }

        protected AppliesAtResult AnyAppliesAt(AppliesAtContext context, bool tail = false)
        {
            if (RejectByStrictness(context))
                return Result(false);
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

        protected virtual ExpressionElement Substitute(AppliesAtContext context)
        {
            var substitute = SubstituteParent(context)
                .Select(element => element.Substitute(context)).ToArray();
            if (expression.SequenceEqual(substitute))
                return this;
            else
                return (ExpressionElement)Activator.CreateInstance(this.GetType(), substitute);
        }

        ExpressionElement[] SubstituteParent(AppliesAtContext context)
        {
            return context.IsParent ? SubstituteParentWhenIsParent() : SubstituteParentWhenIsNotParent();
        }

        ExpressionElement[] SubstituteParentWhenIsParent()
        {
            if (expression.Length == 1 && expression.First() is Parent)
                return new Any().Enclose().ToArray();
            else
                return expression.Select(element => element is Parent ? new Start() : element).ToArray();
        }

        ExpressionElement[] SubstituteParentWhenIsNotParent()
        {
            if (expression.Any(element => element is Parent))
                return expression.Where(element => element is Parent).ToArray();
            else
                return expression;
        }

        bool RejectByStrictness(AppliesAtContext context)
        {
            return context.Strict
                && !expression.All(element => element is Id || element is Literal);
        }
    }
}
