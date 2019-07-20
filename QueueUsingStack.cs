using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class QueueUsingStack : IQueue
    {
        private readonly LinkedListStack stack1;
        private readonly LinkedListStack stack2;

        public QueueUsingStack()
        {
            stack1 = new LinkedListStack();
            stack2 = new LinkedListStack();
        }
        public bool IsEmpty
        {
            get
            {
                return (stack1.Size() == 0 && stack2.Size() == 0);
            }
        } 

        public int Size()
        {
            return stack1.Size() + stack2.Size();
        }

        public void Add(int value)
        {
            stack1.Push(value);
        }

        public int Remove()
        {
            if (stack1.Size() == 0 && stack2.Size() == 0) throw new InvalidOperationException("Queue is empty");

            int value;
            if(stack2.Size() > 0)
            {
                return stack2.Pop();
            }

            while(stack1.Size() > 0)
            {
                value = stack1.Pop();
                stack2.Push(value);
            }
            return stack2.Pop();
        }

        //public static void Main(string[] args)
        //{
        //    var queue = new LinkedListQueue();
        //    queue.Add(2);
        //    queue.Add(4);
        //    queue.Add(6);
        //    queue.Add(8);
        //    queue.Add(10);
        //    for (var i = 0; i < 5; i++)
        //    {
        //        Console.Write(queue.Remove() + " ");
        //    }
        //}
    }
}
