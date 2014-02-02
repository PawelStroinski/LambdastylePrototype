﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class And : ExpressionElement
    {
        public And(ExpressionElement left, ExpressionElement right) : base(left, right) { }
    }
}
