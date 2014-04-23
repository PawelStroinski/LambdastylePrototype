using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter;
using LambdastylePrototype.Interpreter.Subjects;
using Newtonsoft.Json;

namespace LambdastylePrototype
{
    class WriteAsScope
    {
        readonly Dictionary<Sentence, LogEntry> itemLogEntries = new Dictionary<Sentence, LogEntry>();
        ApplyContext context;
        AppliesAtResult appliesAtResult;

        public Sentence GetWriteAs(ApplyContext context, AppliesAtResult appliesAtResult)
        {
            this.context = context;
            this.appliesAtResult = appliesAtResult;
            if (context.Spawner == null)
            {
                var itemLogEntry = appliesAtResult.PositiveLog.LastOrDefault(entry => entry.Type == typeof(Item));
                if (itemLogEntry.Type != null)
                {
                    itemLogEntries[context.Style.Current] = itemLogEntry;
                    var found = FindFirstAdjacentSentenceForSameArray(itemLogEntry.Position);
                    if (found != null)
                        return found;
                }
                return context.Style.Current;
            }
            else
                return context.Spawner;
        }

        Sentence FindFirstAdjacentSentenceForSameArray(PositionStep[] position)
        {
            Sentence found = null;
            foreach (var previous in context.Previous.Reverse())
                if (itemLogEntries.ContainsKey(previous)
                        && position.ExceptLast().SequenceEqual(itemLogEntries[previous].Position.ExceptLast()))
                    found = previous;
                else
                    return found;
            return found;
        }
    }
}
