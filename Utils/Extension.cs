using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype
{
    static class Extension
    {
        public static string ToString(this PositionStep[] position, bool indent)
        {
            var builder = new StringBuilder();
            var indentBy = 0;
            foreach (var item in position)
            {
                if (indent)
                {
                    builder.Append(new string(' ', indentBy * 2));
                    if (item.TokenType == JsonToken.StartObject || item.TokenType == JsonToken.StartArray)
                        indentBy++;
                }
                builder.AppendLine(item.Value == null
                    ? item.TokenType.ToString() : item.TokenType + " = " + item.Value);
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

        public static void WriteLine(string value)
        {
#if !NCRUNCH
            Console.WriteLine(value);
#endif
        }

        public static bool AreOfTypes<T>(this IEnumerable<T> values, params Type[] types)
        {
            return values.Select(item => item.GetType()).SequenceEqual(types);
        }

        public static IEnumerable<T> Enclose<T>(this T item)
        {
            return new List<T> { item };
        }

        public static bool Contains<T>(this IEnumerable<Type> values)
        {
            return values.Contains(typeof(T));
        }
    }
}
