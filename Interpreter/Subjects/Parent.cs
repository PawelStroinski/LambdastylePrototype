using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class Parent : ExpressionElement
    {
        public Parent(params ExpressionElement[] expression) : base(expression) { }

        public override bool HasParent()
        {
            return true;
        }
    }
}
