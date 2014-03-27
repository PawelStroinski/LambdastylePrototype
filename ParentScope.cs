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
        bool ending;

        public ParentScope(Seeker seeker)
        {
            this.seeker = seeker;
        }

        public void BeforePositionChange(PositionStep[] previousPosition)
        {
            if (previousPosition.Any() && previousPosition.Last().TokenType.IsStart())
                foreach (var anchor in anchors.ExceptLast().ToList())
                {
                    anchors.Remove(anchor);
                    if (!seeker.IsCurrentReader(anchor))
                        anchor.Dispose();
                }
            anchors.Add(seeker.GetAnchor());
        }

        public void PositionChanged(PositionStep[] newPosition)
        {
            position = newPosition;
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
            seeker.Seek(anchors.First());
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

        bool End()
        {
            var start = parentPosition.ExceptLast().Last(step => step.TokenType.IsStart());
            var startIndex = parentPosition.ToList().LastIndexOf(start);
            var positionAfterStart = position.Skip(startIndex + 1).ToArray();
            if (positionAfterStart.Any(step => step.TokenType.IsStart()))
                return false;
            else
                return position.Last().TokenType.IsEnd();
        }
    }
}
