using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Or : ExpressionElement
    {
        public Or(ExpressionElement left, ExpressionElement right) : base(left, right) { }

        public override bool AppliesAt(AppliesAtContext context)
        {
            foreach (var element in expression)
                if (!context.InParentOnly || element.HasParent())
                    if (element.AppliesAt(context))
                        return true;
            return false;
        }
    }
}
