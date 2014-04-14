using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter
{
    class MarkerSentence : Sentence
    {
        public MarkerSentence() : base(null) { }

        public bool Reached { get; private set; }

        public override void Apply(ApplyContext context)
        {
            Reached = !context.Strict;
        }
    }
}
