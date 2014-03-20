using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Utils;
using Newtonsoft.Json;

namespace LambdastylePrototype
{
    class Seeker
    {
        readonly EditableStream output;
        readonly GlobalState globalState;
        readonly StreamReader streamReader;
        readonly Action<PositionJsonReader> replaceReader;
        PositionJsonReader reader;

        public Seeker(EditableStream output, GlobalState globalState, StreamReader streamReader,
            Action<PositionJsonReader> replaceReader, PositionJsonReader reader)
        {
            this.output = output;
            this.globalState = globalState;
            this.streamReader = streamReader;
            this.replaceReader = replaceReader;
            this.reader = reader;
        }

        public Anchor GetAnchor()
        {
            return new Anchor(
                outputPosition: output.Position,
                writtenInThisObject: globalState.WrittenInThisObject,
                inputPosition: streamReader.GetPosition()
                    .ShiftByCharacters(-reader.RemainingBufferedCharacters),
                reader: (PositionJsonReader)reader.Clone());
        }

        public void Seek(Anchor anchor)
        {
            if (output.Position != anchor.OutputPosition)
            {
                var count = output.Position - anchor.OutputPosition;
                output.Position = anchor.OutputPosition;
                output.Delete(count);
            }
            globalState.WrittenInThisObject = anchor.WrittenInThisObject;
            streamReader.Seek(anchor.InputPosition);
            reader.Dispose();
            reader = anchor.Reader;
            replaceReader(reader);
        }

        public bool IsCurrentReader(Anchor anchor)
        {
            return anchor.Reader == reader;
        }

        public class Anchor : IDisposable
        {
            public readonly long OutputPosition;
            public readonly bool WrittenInThisObject;
            public readonly StreamReaderSeeker.Position InputPosition;
            public readonly PositionJsonReader Reader;

            public Anchor(long outputPosition, bool writtenInThisObject,
                StreamReaderSeeker.Position inputPosition, PositionJsonReader reader)
            {
                OutputPosition = outputPosition;
                WrittenInThisObject = writtenInThisObject;
                InputPosition = inputPosition;
                Reader = reader;
            }

            public void Dispose()
            {
                Reader.Dispose();
            }
        }
    }
}
