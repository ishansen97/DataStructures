using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public class StackTest
    {
        public int Top { get; set; }

        public int Size { get; set; } = 5;

        private Item[] Items { get; set; }

        public StackTest()
        {
            Top = -1;
            Items = new Item[Size];
        }

        #region stack operations
        public void Push(Item item)
        {
            var result = IsFull();
            if (!IsFull())
            {
                Items[++Top] = item;
                // optional
                /*Top += 1;
                Items[Top] = item;*/
            }
            else
            {
                throw new ArgumentOutOfRangeException("stack eka pirila yako, enna epa");
            }
        }

        public Item Pop()
        {
            if (!IsEmpty())
            {
                //best
                return Items[Top--];

                // optional
                /*var item = Items[Top];
                Top--;
                return item;*/
            }
            throw new ArgumentNullException("empty yako");
        }

        public Item Peek()
        {
            if (!IsEmpty())
            {
                return Items[Top];
            }
            throw new ArgumentNullException("empty yako");
        }

        #endregion

        public bool IsFull() => Top == Size - 1;

        public bool IsEmpty() => Top == -1;
    }
}
