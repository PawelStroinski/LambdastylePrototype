using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using Newtonsoft.Json;

namespace LambdastylePrototype
{
    class GlobalState
    {
        public bool? ForceSyntax;
        public bool Written;
        public bool WrittenOuter;
        public bool WrittenInThisObject;
        public bool WrittenNewLine;
        public List<PredicateIdentity> WrittenEndArray = new List<PredicateIdentity>();
        public List<Tuple<PredicateIdentity, Raw>> WrittenRaw = new List<Tuple<PredicateIdentity, Raw>>();
        public List<PredicateIdentity> Seeked = new List<PredicateIdentity>();
        public JsonToken? InsertedStartToken;
        public List<Sentence> SubjectlessSkippedUntilEnd = new List<Sentence>();
        public bool HasCopyAny;
        public string Last2ndLevelDelimitersBefore;
        public Raw Joining;
        public bool LastApplyingTail;
    }
}
