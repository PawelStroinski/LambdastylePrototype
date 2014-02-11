using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;
using Newtonsoft.Json;

namespace LambdastylePrototype
{
    static class Consts
    {
        public static readonly JsonToken[] ValueTokenTypes = { JsonToken.Boolean, JsonToken.Float, JsonToken.Integer,
                                                               JsonToken.Null, JsonToken.String, JsonToken.Undefined };

        public static readonly Predicate Copy = new Predicate(new OuterId(), new OuterValue());

        public static readonly Sentence CopyAny = new Sentence(new Subject(new Any()), Copy);
    }
}
