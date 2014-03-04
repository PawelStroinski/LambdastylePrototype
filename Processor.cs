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
        bool EOF;
        GlobalState globalState;
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
            parentScope = new ParentScope(input, output, globalState);
            output.InsertMode = true;
            using (writer = new StreamWriter(output))
            using (var reader = new PositionJsonReader(new JsonTextReader(
                    new StreamReader(input), grabDelimiters: true)))
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
                    readResult = reader.Read();
                    parentScope.PositionChanged(reader.Position);
                    if (readResult)
                        styleEnumerator.Current.Apply(CreateContext(reader));
                }
                while (readResult);
                EOF = true;
                styleEnumerator.Current.ApplyEOF(CreateContext(reader));
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
    }
}
