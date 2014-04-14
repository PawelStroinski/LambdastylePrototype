using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter.Predicates;
using LambdastylePrototype.Interpreter.Subjects;
using Newtonsoft.Json;

namespace LambdastylePrototype
{
    static class Extension
    {
        public static string ToDebugString(this IEnumerable<LogEntry> entries)
        {
            if (entries.Any())
                return string.Join(" ", entries.Select(entry => "<"
                    + entry.Type.Name.ToString()
                    + (entry.Tail ? "[TAIL]" : string.Empty)
                    + ">")) + Environment.NewLine;
            else
                return string.Empty;
        }

        public static string ToDebugString(this PositionStep[] position)
        {
            var builder = new StringBuilder();
            var indentBy = 0;
            foreach (var item in position)
            {
                builder.Append(new string(' ', indentBy * 2));
                if (item.TokenType == JsonToken.StartObject || item.TokenType == JsonToken.StartArray)
                    indentBy++;
                builder.AppendLine(item.Value == null
                    ? item.TokenType.ToString() : item.TokenType + " = " + item.Value);
                if (item.ItemIndex != -1)
                {
                    builder.Append(new string(' ', indentBy * 2));
                    builder.AppendLine("[" + item.ItemIndex + "]");
                }
            }
            return builder.ToString();
        }

        public static T Penultimate<T>(this IEnumerable<T> items)
        {
            return items.ElementAt(items.Count() - 2);
        }

        public static bool HasPenultimate<T>(this IEnumerable<T> items)
        {
            return items.Count() >= 2;
        }

        public static bool IsValue(this JsonToken tokenType)
        {
            return Consts.ValueTokenTypes.Contains(tokenType);
        }

        public static bool IsStart(this JsonToken tokenType)
        {
            return Consts.StartTokenTypes.Contains(tokenType);
        }

        public static bool IsEnd(this JsonToken tokenType)
        {
            return Consts.EndTokenTypes.Contains(tokenType);
        }

        public static bool IsInArray(this PositionStep[] position)
        {
            return position.HasPenultimate() && position.Penultimate().TokenType == JsonToken.StartArray;
        }

        public static bool EndsWith(this PositionStep[] position, JsonToken tokenType)
        {
            return position.Any() && position.Last().TokenType == tokenType;
        }

        public static JsonToken LastTokenType(this PositionStep[] position)
        {
            return position.Any() ? position.Last().TokenType : JsonToken.None;
        }

        public static void WriteDebug(string value)
        {
#if !NCRUNCH
            Console.Write(value);
            NLog.LogManager.GetCurrentClassLogger().Debug(value);
#endif
        }

        public static void WriteDebugLine(string value)
        {
#if !NCRUNCH
            Console.WriteLine(value);
            NLog.LogManager.GetCurrentClassLogger().Debug(value + Environment.NewLine);
#endif
        }

        public static bool AreOfTypes<T>(this IEnumerable<T> values, params Type[] types)
        {
            return values.Select(item => item.GetType()).SequenceEqual(types);
        }

        public static IEnumerable<T> ExceptLast<T>(this IEnumerable<T> source)
        {
            return source.Any() ? source.Take(source.Count() - 1) : source;
        }

        public static IEnumerable<T> Enclose<T>(this T item)
        {
            return new List<T> { item };
        }

        public static bool Contains<T>(this IEnumerable<LogEntry> entries)
        {
            return entries.Any(entry => entry.Type == typeof(T));
        }

        public static bool ContainsAssignableTo<T>(this IEnumerable<LogEntry> entries)
        {
            return entries.Any(entry => typeof(T).IsAssignableFrom(entry.Type));
        }

        public static bool ContainsTail(this IEnumerable<LogEntry> entries)
        {
            return entries.Any(entry => entry.Tail);
        }

        public static bool Contains<T>(this IEnumerable<Type> types)
        {
            return types.Contains(typeof(T));
        }

        public static string EnforceComma(this string value)
        {
            return value.Contains(",") ? value : "," + value.IfEmpty(" ");
        }

        public static string IfEmpty(this string value, string ifEmpty)
        {
            return value == string.Empty ? ifEmpty : value;
        }

        public static void ResetAndMoveNext(this IEnumerator enumerator)
        {
            enumerator.Reset();
            enumerator.MoveNext();
        }

        public static bool StartsWith<T>(this IEnumerable<T> starts, IEnumerable<T> with)
        {
            return starts.Take(with.Count()).SequenceEqual(with);
        }
    }
}
