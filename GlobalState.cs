using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter;
using Newtonsoft.Json;

namespace LambdastylePrototype
{
    class GlobalState
    {
        public bool? ForceSyntax;
        public bool Written;
        public bool WrittenOuter;
        public bool WrittenInThisObject;
        public JsonToken? InsertedStartToken;
        public List<Sentence> SubjectlessSkippedUntilEnd = new List<Sentence>();
        public bool HasCopyAny;
        public string Last2ndLevelDelimitersBefore;
    }
}
