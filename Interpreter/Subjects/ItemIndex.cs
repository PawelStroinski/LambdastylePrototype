using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdastylePrototype.Interpreter.Subjects
{
    class ItemIndex : Item
    {
        readonly int itemIndex;

        public ItemIndex(int itemIndex)
        {
            this.itemIndex = itemIndex;
        }
    }
}
