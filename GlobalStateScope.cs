using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter;

namespace LambdastylePrototype
{
    class GlobalStateScope
    {
        readonly Scope root = new Scope();
        readonly Dictionary<Sentence, Scope> scopes = new Dictionary<Sentence, Scope>();
        readonly Stack<Scope> previous = new Stack<Scope>();
        public Scope Current { get; private set; }

        public GlobalStateScope()
        {
            Current = root;
        }

        public void Start(Sentence sentence, bool writtenCurrent)
        {
            previous.Push(Current);
            if (scopes.ContainsKey(sentence))
                Current = scopes[sentence];
            else
            {
                scopes[sentence] = Current = root.Copy();
                if (writtenCurrent)
                    Current.WrittenInThisObject = true;
            }
        }

        public void ReturnToPrevious()
        {
            Current = previous.Pop();
        }

        public void Forget(Sentence sentence)
        {
            scopes.Remove(sentence);
        }

        public class Scope
        {
            public bool WrittenInThisObject;

            public Scope Copy()
            {
                var copy = new Scope();
                foreach (var field in typeof(Scope).GetFields())
                    field.SetValue(copy, field.GetValue(this));
                return copy;
            }
        }
    }
}
