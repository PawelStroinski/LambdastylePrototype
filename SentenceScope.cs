using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter;
using Newtonsoft.Json;

namespace LambdastylePrototype
{
    class SentenceScope
    {
        readonly Dictionary<Sentence, PositionStep[]> startsAt;
        readonly Dictionary<Sentence, PositionStep[]> endedAt = new Dictionary<Sentence, PositionStep[]>();
        ApplyContext context;
        JsonToken tokenType;

        public SentenceScope()
            : this(new Dictionary<Sentence, PositionStep[]>())
        {
        }

        SentenceScope(Dictionary<Sentence, PositionStep[]> startsAt)
        {
            this.startsAt = startsAt;
        }

        public void Change(ApplyContext context)
        {
            SetContext(context);
            if (IsStart() && !Continues())
                startsAt[context.Style.Current] = context.Position;
            if (IsEnd())
                startsAt.Remove(context.Style.Current);
        }

        public PositionStep[] StartsAt()
        {
            if (Continues())
                return startsAt[context.Style.Current];
            else
                return context.Position;
        }

        public bool EndsAt(ApplyContext context, bool appliedSentence)
        {
            if (appliedSentence)
            {
                if (Continues())
                    return false;
                else
                    if (!endedAt.ContainsKey(context.Style.Current)
                        || endedAt[context.Style.Current].SequenceEqualIgnoringItemIndex(context.Position))
                    {
                        endedAt[context.Style.Current] = context.Position;
                        return true;
                    }
                    else
                        return false;
            }
            else
            {
                var sentenceScope = new SentenceScope(startsAt);
                sentenceScope.SetContext(context);
                return sentenceScope.IsEnd();
            }
        }

        void SetContext(ApplyContext context)
        {
            this.context = context;
            tokenType = context.Position.Last().TokenType;
        }

        bool Continues()
        {
            return startsAt.ContainsKey(context.Style.Current)
                && context.Position.StartsWith(startsAt[context.Style.Current]);
        }

        bool IsStart()
        {
            return tokenType.IsStart();
        }

        bool IsEnd()
        {
            return tokenType.IsEnd() && Continues()
                && startsAt[context.Style.Current].SequenceEqual(context.Position.ExceptLast());
        }
    }
}
