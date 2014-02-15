﻿using System;
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
        {
            this.reader = reader;
            position = new Stack<PositionStep>();
        }

        public PositionStep[] Position { get { return position.Reverse().ToArray(); } }

        public override bool Read()
        {
            var result = reader.Read();
            if (result)
            {
                Pop();
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

        void IDisposable.Dispose()
        {
            (reader as IDisposable).Dispose();
        }

        void Pop()
        {
            if (position.Any() && position.Peek().TokenType == JsonToken.EndObject)
            {
                position.Pop();
                while (position.Any())
                    if (position.Pop().TokenType == JsonToken.StartObject)
                        break;
            }
            if (position.Any() && position.Peek().TokenType == JsonToken.EndArray)
            {
                position.Pop();
                while (position.Any())
                    if (position.Pop().TokenType == JsonToken.StartArray)
                        break;
            }
            var currentTokenType = reader.TokenType;
            if (currentTokenType == JsonToken.PropertyName)
                while (position.Any())
                    if (position.Peek().TokenType == JsonToken.StartObject)
                        break;
                    else
                        position.Pop();
            if (currentTokenType.IsValue())
                while (position.Any() && position.Peek().TokenType.IsValue())
                    position.Pop();
        }

        void Push()
        {
            position.Push(new PositionStep(
                tokenType: reader.TokenType,
                value: reader.Value,
                delimitersBefore: reader.DelimitersBefore,
                delimitersAfter: reader.DelimitersAfter));
        }

        void AppendDelimitersAfter()
        {
            var last = position.Pop();
            position.Push(new PositionStep(
                tokenType: last.TokenType,
                value: last.Value,
                delimitersBefore: last.DelimitersBefore,
                delimitersAfter: last.DelimitersAfter + reader.DelimitersAfter));
        }
    }
}