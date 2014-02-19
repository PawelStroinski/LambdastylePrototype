using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Subject : ExpressionElement
    {
        public Subject(params ExpressionElement[] expression) : base(expression) { }

        public override bool AppliesAt(AppliesAtContext context)
        {
            if (context.InParentOnly && !HasParent())
                return false;
            return base.AppliesAt(context);
        }
    }
}
