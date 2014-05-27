using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;

namespace LambdastylePrototype.Parser
{
    class SentenceDraft
    {
        public Subject Subject;
        public Predicate Predicate;
        public Sentence[] Children = new Sentence[0];
    }
}
