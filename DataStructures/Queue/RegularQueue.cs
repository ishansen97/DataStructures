using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queue
{
    public class RegularQueue
    {
        private QueueItem[] QueueItems{ get; set; }

        public int Front { get; set; }

        public int Rear { get; set; }

        public int Size { get; set; } = 5;

        public int Count { get; set; }

        public RegularQueue()
        {
            Front = 0;
            Rear = -1;
            Count = 0;
            QueueItems = new QueueItem[Size];
        }

        // enqueue operation
        public void Enqueue(QueueItem item)
        {
            if (IsFull()) throw new InvalidOperationException("mehe ida na yako");
            QueueItems[++Rear] = item;
            Count++;
        }

        // dequeue operation
        public QueueItem Dequeue()
        {
            if (IsEmpty()) throw new IndexOutOfRangeException("meka athule mukuth na bola");
            Count--;
            return QueueItems[Front++];
        }

        // peek
        public QueueItem Peek()
        {
            if (IsEmpty()) throw new IndexOutOfRangeException("meka athule mukuth na bola");
            return QueueItems[Front];
        }


        // full
        public bool IsFull() => Rear == Size - 1;

        // empty
        public bool IsEmpty() => Count == 0;
    }
}
