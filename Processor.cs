using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Utils;
using Newtonsoft.Json;

namespace LambdastylePrototype
{
    class Processor
    {
        readonly Stream input;
        readonly EditableStream output;
        readonly Sentence[] style;
        readonly IEnumerator<Sentence> styleEnumerator;
        readonly Dictionary<Sentence, long> startsAt = new Dictionary<Sentence, long>();
        readonly Dictionary<Sentence, long> endsAt = new Dictionary<Sentence, long>();
        StreamWriter writer;
        StreamReader streamReader;
        PositionJsonReader reader;
        bool EOF;
        GlobalState globalState;
        Seeker seeker;
        ParentScope parentScope;

        public Processor(Stream input, EditableStream output, params Sentence[] style)
        {
            this.input = input;
            this.output = output;
            this.style = style;
            this.styleEnumerator = style.Cast<Sentence>().GetEnumerator();
        }

        public void Process()
        {
            bool readResult;
            EOF = false;
            globalState = new GlobalState();
            output.InsertMode = true;
            using (writer = new StreamWriter(output))
            using (streamReader = new StreamReader(input))
            {
                reader = new PositionJsonReader(new JsonTextReader(streamReader, grabDelimiters: true));
                reader.CloseInput = false;
                seeker = new Seeker(output, globalState, streamReader, ReplaceReader, reader);
                parentScope = new ParentScope(seeker);
                try
                {
                    if (!style.Any())
                        return;
                    styleEnumerator.Reset();
                    styleEnumerator.MoveNext();
                    styleEnumerator.Current.ApplyBOF(CreateContext(reader));
                    do
                    {
                        styleEnumerator.Reset();
                        styleEnumerator.MoveNext();
                        parentScope.BeforePositionChange(reader.Position);
                        readResult = reader.Read();
                        if (readResult && !reader.Position.EndsWith(JsonToken.PropertyName))
                        {
                            parentScope.PositionChanged(reader.Position);
                            styleEnumerator.Current.Apply(CreateContext(reader));
                        }
                    }
                    while (readResult);
                    EOF = true;
                    styleEnumerator.Current.ApplyEOF(CreateContext(reader));
                }
                finally
                {
                    reader.Dispose();
                    parentScope.Dispose();
                }
            }
        }

        ApplyContext CreateContext(PositionJsonReader reader)
        {
            return new ApplyContext(style: styleEnumerator,
                                    position: reader.Position,
                                    write: Write,
                                    written: Written,
                                    globalState: globalState,
                                    parentScope: parentScope);
        }

        void Write(string value, Sentence sentence, bool rewind, int seekBy)
        {
            if (rewind)
            {
                RewindOutputTo(NextWrittenSentence(sentence), beingWritten: sentence);
                startsAt[sentence] = output.Position;
            }
            if (seekBy != 0)
                output.Position += seekBy;
            var position = output.Position;
            writer.Write(value);
            writer.Flush();
            ShiftNextWrittenSentences(sentence, output.Position - position);
            if (rewind)
                endsAt[sentence] = output.Position;
            RewindOutputToEOF();
        }

        void RewindOutputTo(Sentence sentence, Sentence beingWritten)
        {
            if (sentence != null)
                output.Position = startsAt[sentence];
            else
                if (endsAt.ContainsKey(beingWritten))
                    output.Position = endsAt[beingWritten];
                else
                    if (EOF)
                        RewindOutputToEOF();
        }

        void RewindOutputToEOF()
        {
            output.Seek(0, SeekOrigin.End);
        }

        Sentence NextWrittenSentence(Sentence after)
        {
            foreach (var sentence in style.SkipWhile(sentence => sentence != after).Skip(1))
                if (Written(sentence))
                    return sentence;
            return null;
        }

        void ShiftNextWrittenSentences(Sentence after, long shiftBy)
        {
            foreach (var sentence in style.SkipWhile(sentence => sentence != after).Skip(1))
                if (Written(sentence))
                {
                    startsAt[sentence] += shiftBy;
                    endsAt[sentence] += shiftBy;
                }
        }

        bool Written(Sentence sentence)
        {
            return startsAt.ContainsKey(sentence);
        }

        void ReplaceReader(PositionJsonReader value)
        {
            reader = value;
        }
    }
}
