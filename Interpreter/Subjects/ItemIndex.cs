using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class ItemIndex : Item
    {
        readonly int itemIndex;

        public ItemIndex(int itemIndex)
        {
            this.itemIndex = itemIndex;
        }

        public override AppliesAtResult AppliesAt(AppliesAtContext context)
        {
            if (base.AppliesAt(context).Result)
            {
                var startArray = context.Position
                    .Reverse()
                    .Skip(1)
                    .SkipWhile(step => step.TokenType != JsonToken.StartArray)
                    .First();
                return Result(startArray.ItemIndex == itemIndex);
            }
            else
                return Result(false);
        }
    }
}
