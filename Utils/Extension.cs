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
    }
}
