using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter;
using Newtonsoft.Json;

namespace LambdastylePrototype
{
    class ParentScope
    {
        readonly Stream input;
        readonly EditableStream output;
        readonly GlobalState globalState;
        Tuple<long, long> startTokenWasAt, propertyNameTokenWasAt;
        PositionStep[] position, parentPosition;
        Sentence parent;
        bool ending, writtenInThisObject;

        public ParentScope(Stream input, EditableStream output, GlobalState globalState)
        {
            this.input = input;
            this.output = output;
            this.globalState = globalState;
        }

        public void PositionChanged(PositionStep[] position)
        {
            this.position = position;
            var tokenType = position.Last().TokenType;
            if (tokenType.IsStart())
            {
                if (position.HasPenultimate() && position.Penultimate().TokenType == JsonToken.PropertyName)
                    startTokenWasAt = propertyNameTokenWasAt;
                else
                    startTokenWasAt = At();
                writtenInThisObject = globalState.WrittenInThisObject;
            }
            if (tokenType == JsonToken.PropertyName)
                propertyNameTokenWasAt = At();
            if (ending)
            {
                ending = false;
                parent = null;
            }
            if (parent != null && End())
                ending = true;
        }

        public void ParentFound(Sentence parent)
        {
            this.parent = parent;
            this.parentPosition = position;
            var inputPosition = startTokenWasAt.Item1;
            var outputPosition = startTokenWasAt.Item2;
            input.Position = inputPosition;
            if (output.Position != outputPosition)
            {
                var count = output.Position - outputPosition;
                output.Position = outputPosition;
                output.Delete(count);
            }
            globalState.WrittenInThisObject = writtenInThisObject;
        }

        public bool IsParent(Sentence sentence)
        {
            return parent == sentence;
        }

        Tuple<long, long> At()
        {
            return new Tuple<long, long>(input.Position, output.Position);
        }

        bool End()
        {
            var start = parentPosition.Last(step => step.TokenType.IsStart());
            var startIndex = parentPosition.ToList().IndexOf(start);
            var positionAfterStart = position.Skip(startIndex + 1).ToArray();
            if (positionAfterStart.Any(step => step.TokenType.IsStart()))
                return false;
            else
                return position.Last().TokenType.IsEnd();
        }
    }
}
