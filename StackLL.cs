using System;

namespace Algorithms
{
    public class StackLL
    {
        private Node head = null;
        private int count = 0;

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

        public int Size()
        {
            return count;
        }

        public bool IsEmpty
        {
            get { return count == 0; }
        }

        public void Print()
        {
            var temp = head;
            while (temp != null)
            {
                Console.Write(temp.value + " ");
                temp = temp.next;
            }
        }

        public void Push(int value)
        {
            head = new Node(value, head);
            count++;
        }

        public int Pop()
        {
            if(IsEmpty) throw new InvalidOperationException("StackEmptyException");

            var topVal = head.value;
            var temp = head.next;
            head.next = null;
            head = temp;
            count--;
            return topVal;
        }

        public int Peek()
        {
            if (IsEmpty) throw new InvalidOperationException("StackEmptyException");

            return head.value;
        }

        public void InsertAtBottom(int value)
        {
            if (IsEmpty)
            {
                Push(value);
            }
            else
            {
                int temp = Pop();
                InsertAtBottom(value);
                Push(temp);
            }
        }
    }
}
