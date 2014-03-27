using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Predicates
{
    class PredicateScope
    {
        readonly Dictionary<PredicateIdentity, Scope> scopes = new Dictionary<PredicateIdentity, Scope>();
        PredicateContext context;
        JsonToken tokenType;

        public void Change(PredicateContext context)
        {
            this.context = context;
            tokenType = context.Position.LastTokenType();
            if (IsStart() && !Continues())
                scopes[context.PredicateIdentity] = new Scope(startsAt: context.Position);
            if (IsEnd())
                scopes.Remove(context.PredicateIdentity);
        }

        public bool Written()
        {
            return Continues() && scopes[context.PredicateIdentity].Written;
        }

        public void SetWritten()
        {
            if (Continues())
                scopes[context.PredicateIdentity] = scopes[context.PredicateIdentity].Copy(written: true);
        }

        bool Continues()
        {
            return scopes.ContainsKey(context.PredicateIdentity);
        }

        bool IsStart()
        {
            return tokenType.IsStart();
        }

        bool IsEnd()
        {
            return tokenType.IsEnd() && Continues()
                && scopes[context.PredicateIdentity].StartsAt.SequenceEqual(context.Position.ExceptLast());
        }

        struct Scope
        {
            public readonly PositionStep[] StartsAt;
            public readonly bool Written;

            public Scope(PositionStep[] startsAt) : this(startsAt, written: false) { }

            Scope(PositionStep[] startsAt, bool written)
            {
                StartsAt = startsAt;
                Written = written;
            }

            public Scope Copy(bool written)
            {
                return new Scope(StartsAt, written: written);
            }
        }
    }
}
