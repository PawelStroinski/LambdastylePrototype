using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter;

namespace Test
{
    class Builder
    {
        public readonly List<Sentence> Style = new List<Sentence>();

        public void Add(params Sentence[] style)
        {
            Style.AddRange(style);
        }
    }
}
