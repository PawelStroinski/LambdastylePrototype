using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Subjects;

namespace LambdastylePrototype
{
    class ReducedsScope
    {
        readonly Dictionary<Key, ExpressionElement> reduced = new Dictionary<Key, ExpressionElement>();
        ApplyContext context;
        Key key;
        bool ending;

        public void Change(ApplyContext context)
        {
            this.context = context;
            if (ending)
            {
                reduced.Remove(key);
                ending = false;
            }
            var tokenType = context.Position.Last().TokenType;
            if (tokenType.IsEnd())
                ending = true;
            key = GetKey();
        }

        public ExpressionElement GetReduced()
        {
            if (reduced.ContainsKey(key))
                return reduced[key];
            else
                return null;
        }

        public void SetReduced(ExpressionElement reduced)
        {
            this.reduced[key] = reduced;
        }

        Key GetKey()
        {
            var position = context.Position;
            var tokenType = position.Last().TokenType;
            if (position.Length > 1 && tokenType.IsStart())
                position = position.ExceptLast().ToArray();
            position = position.Reverse().SkipWhile(step => !step.TokenType.IsStart()).Reverse().ToArray();
            return new Key(context.Style.Current, position);
        }

        struct Key
        {
            public readonly Sentence Sentence;
            public readonly PositionStep[] Position;

            public Key(Sentence sentence, PositionStep[] position)
            {
                Sentence = sentence;
                Position = position;
            }

            public override bool Equals(object obj)
            {
                if (!(obj is Key))
                    return false;
                var compared = (Key)obj;
                return Sentence == compared.Sentence
                    && Position.SequenceEqual(compared.Position);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    var hash = 3;
                    hash = hash * 5 + Sentence.GetHashCode();
                    foreach (var step in Position)
                        hash = hash * 5 + step.GetHashCode();
                    return hash;
                }
            }
        }
    }
}
