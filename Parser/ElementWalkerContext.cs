using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr.Runtime.Tree;

namespace LambdastylePrototype.Parser
{
    struct ElementWalkerContext
    {
        public readonly Builder Builder;
        public readonly PredicateRawBuffer PredicateRawBuffer;
        public readonly Action<CommonTree[]> WalkSubjectElements;

        public ElementWalkerContext(Builder builder, PredicateRawBuffer predicateRawBuffer,
            Action<CommonTree[]> walkSubjectElements)
        {
            Builder = builder;
            PredicateRawBuffer = predicateRawBuffer;
            WalkSubjectElements = walkSubjectElements;
        }
    }
}
