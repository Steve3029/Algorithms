using System;

namespace Algorithms
{
    class CircularQueue : IQueue
    {
        private int count;
        private readonly int capacity;
        private readonly int[] data;
        private int front = 0;
        private int back = -1;
        public CircularQueue(int size)
        {
            capacity = size;
            data = new int[capacity];
        }

        public CircularQueue() : this(100)
        {
        }
        public void Add(int value)
        {
            if (count >= capacity) throw new OutOfMemoryException("out of queue capacity");

            back++;
            data[back % capacity] = value;
            count++;
        }

        public int Remove()
        {
            if (IsEmpty) throw new InvalidOperationException("Queue is empty");

            var value = data[front % capacity];
            front++;
            count--;
            return value;
        }

        public bool IsEmpty
        {
            get
            {
                return count == 0;
            }
        }

        public int Size()
        {
            return count;
        }
    }
}
