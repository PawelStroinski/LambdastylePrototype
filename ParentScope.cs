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
    class ParentScope : IDisposable
    {
        readonly Seeker seeker;
        readonly List<Seeker.Anchor> anchors = new List<Seeker.Anchor>();
        PositionStep[] position, parentPosition;
        Sentence parent;
        bool ending, removing;

        public ParentScope(Seeker seeker)
        {
            this.seeker = seeker;
        }

        public bool JustFoundParent { get; private set; }

        public PositionStep[] StartedAt { get; private set; }

        public void PositionChanged(PositionStep[] newPosition)
        {
            position = newPosition;
            AddRemoveAnchor();
            if (ending)
            {
                ending = false;
                parent = null;
            }
            if (parent != null && End())
                ending = true;
            JustFoundParent = false;
        }

        public void ParentFound(Sentence parent)
        {
            this.parent = parent;
            this.parentPosition = position;
            var anchor = position.LastTokenType().IsStart() ? anchors.Penultimate() : anchors.Last();
            seeker.Seek(anchor);
            JustFoundParent = true;
            StartedAt = anchor.Reader.Position;
        }

        public bool IsParent(Sentence sentence)
        {
            return parent == sentence;
        }

        public void Dispose()
        {
            foreach (var anchor in anchors)
                anchor.Dispose();
        }

        void AddRemoveAnchor()
        {
            if (removing)
            {
                var anchor = anchors.Last();
                if (!seeker.IsCurrentReader(anchor))
                    anchor.Dispose();
                anchors.Remove(anchor);
                removing = false;
            }
            var tokenType = position.LastTokenType();
            if (tokenType.IsStart())
                anchors.Add(seeker.GetAnchor());
            else
                if (tokenType.IsEnd())
                    removing = true;
        }

        bool End()
        {
            var start = parentPosition.ExceptLast().Last(step => step.TokenType.IsStart());
            var startIndex = parentPosition.ExceptLast().ToList().LastIndexOf(start);
            var positionAfterStart = position.Skip(startIndex + 1).ToArray();
            if (positionAfterStart.Any(step => step.TokenType.IsStart()))
                return false;
            else
                return position.Last().TokenType.IsEnd();
        }
    }
}
