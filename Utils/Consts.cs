using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static readonly JsonToken[] StartTokenTypes = { JsonToken.StartArray, JsonToken.StartObject };

        public static readonly JsonToken[] EndTokenTypes = { JsonToken.EndArray, JsonToken.EndObject };

        public static readonly Predicate Copy = new Predicate(new OuterId(), new OuterValue());

        public static readonly Sentence CopyAny = new Sentence(new Subject(new Any()), Copy);

        public static readonly string StringRegExp = @"""(?:\\.|[^\\""])*""";

        public static readonly string StartsWithPropertyName = @"^\s*" + StringRegExp + @"\s*:";

        public static readonly string StartsWithStartArray = @"^\s*\[";

        public static readonly string StartsWithStartObject = @"^\s*\{";

        public static readonly string EndsWithEndArray = @"\]\s*$";

        public static readonly string EndsWithEndObject = @"\}\s*$";

        public static readonly string EndsWithStartObject = @"\{\s*$";

        public static readonly string PropertyName = StartsWithPropertyName + @"\s*$";

        public static readonly string StartsWithColon = @"^\s*:";
    }
}
