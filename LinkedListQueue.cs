using System;

namespace Algorithms
{
    class LinkedListQueue : IQueue
    {
        private class Node
        {
            internal int value;
            internal Node next;

            public Node(int v, Node n)
            {
                value = v;
                next = n;
            }
        }
        private int count = 0;
        private Node tail = null;

        public int Size()
        {
            return count;
        }

        public bool IsEmpty
        {
            get
            {
                return count == 0;
            }
        }

        public void Add(int value)
        {
            var temp = new Node(value, null);
            if (tail == null)
            {
                tail = temp;
                tail.next = tail;
            }
            else
            {
                temp.next = tail.next;
                tail.next = temp;
                tail = temp;
            }
            count++;
        }

        public int Remove()
        {
            if (IsEmpty) throw new InvalidOperationException("Queue is empty");

            var temp = tail.next;
            if (tail == tail.next)
            {
                tail = null;
            }
            else
            {
                tail.next = tail.next.next;
            }
            count--;
            return temp.value;
        }
    }
}
