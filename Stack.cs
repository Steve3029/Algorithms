using System;

namespace Algorithms
{
    public class Stack
    {
        private int capacity;
        private readonly int minCapacity;
        private int[] data;
        private int top = -1;

        public Stack() : this(1000)
        {
        }

        public Stack(int size)
        {
            data = new int[size];
            capacity = minCapacity = size;
        }

        public bool IsEmpty
        {
            get { return (top == -1); }
        }

        public int Size()
        {
            return (top + 1);
        }

        public void Print()
        {
            foreach (var item in data)
            {
                Console.Write(item + " ");
            }
        }

        public void Push(int value)
        {
            if (Size() == capacity)
            {
                var newData = new int[capacity * 2];
                Array.Copy(data, 0, newData, 0, capacity);
                data = newData;
                capacity *= 2;
            }
            top++;
            data[top] = value;
        }

        public int Pop()
        {
            if (IsEmpty) throw new InvalidOperationException("StackEmptyException");

            int topVal = data[top];
            top--;
            if (Size() == capacity/2 && capacity > minCapacity)
            {
                capacity /= 2;
                var newData = new int[capacity];
                Array.Copy(data, 0, newData, 0, capacity);
                data = newData;
            }
            return topVal;
        }

        public int Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("StackEmptyException");
            return data[top];
        }
    }
}
