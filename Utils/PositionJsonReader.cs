using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Utils
{
    class PositionJsonReader : JsonReader, IDisposable
    {
        readonly JsonReader reader;
        readonly Stack<PositionStep> position;

        public PositionJsonReader(JsonReader reader)
            : this(reader: reader, position: new Stack<PositionStep>())
        {
        }

        PositionJsonReader(JsonReader reader, Stack<PositionStep> position)
        {
            this.reader = reader;
            this.position = position;
        }

        public PositionStep[] Position { get { return position.Reverse().ToArray(); } }

        public override bool Read()
        {
            var result = reader.Read();
            if (result)
            {
                Pop();
                IncreaseItemIndex();
                Push();
            }
            else
                AppendDelimitersAfter();
            return result;
        }

        public override byte[] ReadAsBytes()
        {
            return reader.ReadAsBytes();
        }

        public override DateTime? ReadAsDateTime()
        {
            return reader.ReadAsDateTime();
        }

        public override DateTimeOffset? ReadAsDateTimeOffset()
        {
            return reader.ReadAsDateTimeOffset();
        }

        public override decimal? ReadAsDecimal()
        {
            return reader.ReadAsDecimal();
        }

        public override int? ReadAsInt32()
        {
            return reader.ReadAsInt32();
        }

        public override string ReadAsString()
        {
            return reader.ReadAsString();
        }

        public override bool CloseInput
        {
            get { return reader.CloseInput; }
            set { if (reader != null) reader.CloseInput = value; }
        }

        public override int RemainingBufferedCharacters { get { return reader.RemainingBufferedCharacters; } }

        public override JsonReader Clone()
        {
            return new PositionJsonReader(reader: reader.Clone(), position: new Stack<PositionStep>(Position));
        }

        public void Dispose()
        {
            (reader as IDisposable).Dispose();
        }

        void Pop()
        {
            if (position.Any() && position.Peek().TokenType.IsEnd())
            {
                position.Pop();
                position.Pop();
            }
            var currentTokenType = reader.TokenType;
            if (currentTokenType == JsonToken.PropertyName)
                while (position.Any())
                    if (position.Peek().TokenType == JsonToken.StartObject)
                        break;
                    else
                        position.Pop();
            while (position.Any() && position.Peek().TokenType.IsValue())
                position.Pop();
            if (currentTokenType.IsEnd())
                while (position.Any() && !position.Peek().TokenType.IsStart())
                    position.Pop();
        }

        void IncreaseItemIndex()
        {
            if (position.Any() && position.Peek().TokenType == JsonToken.StartArray)
            {
                var last = position.Pop();
                position.Push(last.Copy(
                    itemIndex: reader.TokenType == JsonToken.EndArray ? -1 : (int)last.ItemIndex + 1));
            }
        }

        void Push()
        {
            position.Push(new PositionStep(
                tokenType: reader.TokenType,
                value: reader.Value,
                delimitersBefore: reader.DelimitersBefore,
                delimitersAfter: reader.DelimitersAfter,
                itemIndex: -1));
        }

        void AppendDelimitersAfter()
        {
            var last = position.Pop();
            position.Push(new PositionStep(
                tokenType: last.TokenType,
                value: last.Value,
                delimitersBefore: last.DelimitersBefore,
                delimitersAfter: last.DelimitersAfter + reader.DelimitersAfter,
                itemIndex: last.ItemIndex));
        }
    }
}
