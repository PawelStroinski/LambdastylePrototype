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
        readonly Dictionary<Sentence, PositionStep[]> startsAt = new Dictionary<Sentence, PositionStep[]>();
        ApplyContext context;
        JsonToken tokenType;

        public void Change(ApplyContext context)
        {
            this.context = context;
            tokenType = context.Position.Last().TokenType;
            if (IsStart() && !Continues())
                startsAt[context.Style.Current] = context.Position;
            if (IsEnd())
                startsAt.Remove(context.Style.Current);
        }

        public bool Continues()
        {
            return startsAt.ContainsKey(context.Style.Current);
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
