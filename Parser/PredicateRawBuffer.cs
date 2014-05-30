using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Parser
{
    class PredicateRawBuffer
    {
        public const char Pipe = '|';
        public const char Ampersand = '&';
        public const char Hash = '#';
        public const char Backslash = '\\';
        readonly Builder builder;
        readonly StringBuilder internalBuffer = new StringBuilder();
        string raw;
        int position;
        bool skipNextChar;
        public bool EscapeNextPredicateElement;

        public PredicateRawBuffer(Builder builder)
        {
            this.builder = builder;
        }

        public void Append(string value)
        {
            internalBuffer.Append(value);
        }

        public void AppendLine()
        {
            internalBuffer.AppendLine();
        }

        public void FlushRawToPredicate()
        {
            if (internalBuffer.Length > 0)
            {
                raw = internalBuffer.ToString();
                var splet = raw.Split(Pipe, Ampersand, Hash, Backslash);
                position = 0;
                skipNextChar = false;
                foreach (var spletItem in splet)
                    if (raw.Length <= position)
                        break;
                    else
                        OnSpletItem(spletItem);
                internalBuffer.Clear();
            }
        }

        void OnSpletItem(string spletItem)
        {
            var spletAt = raw[position];
            switch (spletAt)
            {
                case Pipe:
                    OnTokenChar(() => builder.AddInnerValueToPredicate());
                    break;
                case Ampersand:
                    OnTokenChar(() => builder.AddOuterValueToPredicate());
                    break;
                case Hash:
                    OnTokenChar(() => builder.AddOuterIdToPredicate());
                    break;
                case Backslash:
                    OnBackslashChar();
                    break;
                default:
                    break;
            }
            if (spletItem != string.Empty)
            {
                if (skipNextChar)
                {
                    if (spletItem.Length > 1)
                        builder.AddRawToPredicate(spletItem.Substring(1));
                }
                else
                    builder.AddRawToPredicate(spletItem);
                position += spletItem.Length;
                skipNextChar = false;
            }
        }

        void OnTokenChar(Action tokenAction)
        {
            if (!skipNextChar)
                tokenAction();
            skipNextChar = false;
            position++;
        }

        void OnBackslashChar()
        {
            if (skipNextChar)
                skipNextChar = false;
            else
                if (raw.Length > position + 1)
                {
                    var nextChar = raw[position + 1];
                    OnNextCharAfterBackslash(nextChar);
                    skipNextChar = true;
                }
                else
                    EscapeNextPredicateElement = true;
            position++;
        }

        void OnNextCharAfterBackslash(char nextChar)
        {
            switch (nextChar)
            {
                case '0':
                    builder.AddRawToPredicate("\0");
                    break;
                case 'a':
                    builder.AddRawToPredicate("\a");
                    break;
                case 'b':
                    builder.AddRawToPredicate("\b");
                    break;
                case 'f':
                    builder.AddRawToPredicate("\f");
                    break;
                case 'n':
                    builder.AddRawToPredicate("\n");
                    break;
                case 'r':
                    builder.AddRawToPredicate("\r");
                    break;
                case 't':
                    builder.AddRawToPredicate("\t");
                    break;
                case 'v':
                    builder.AddRawToPredicate("\v");
                    break;
                default:
                    if (Char.IsDigit(nextChar))
                        builder.AddRegExpGroupToPredicate(int.Parse(nextChar.ToString()));
                    else
                        builder.AddRawToPredicate(nextChar.ToString());
                    break;
            }
        }
    }
}
