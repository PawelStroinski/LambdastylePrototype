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
        public HashSet<PredicateIdentity> WrittenPredicate = new HashSet<PredicateIdentity>();
        public List<PredicateIdentity> Seeked = new List<PredicateIdentity>();
        public List<PredicateIdentity> AddedNewLine = new List<PredicateIdentity>();
        public Dictionary<PredicateIdentity, PositionStep[]> TailBoundaryUsed
            = new Dictionary<PredicateIdentity, PositionStep[]>();
        public JsonToken? InsertedStartToken;
        public List<Sentence> SubjectlessSkippedUntilEnd = new List<Sentence>();
        public bool HasCopyAny;
        public string Last2ndLevelDelimitersBefore;
        public Raw Joining;
        public bool LastApplyingTail;
        public readonly PredicateScope PredicateScope = new PredicateScope();

        public GlobalState Copy()
        {
            var copy = new GlobalState();
            copy.Written = Written;
            copy.WrittenOuter = WrittenOuter;
            copy.WrittenInThisObject = WrittenInThisObject;
            return copy;
        }
    }
}
