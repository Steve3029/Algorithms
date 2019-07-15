using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class StackSolutions
    {
        public static void SortStack(LinkedListStack stack)
        {
            int temp;
            if (stack.Size() > 0)
            {
                temp = stack.Pop();
                SortStack(stack);
                SortedInsert(stack, temp);
            }
        }

        public static void SortedInsert(LinkedListStack stack, int value)
        {
            if(stack.Size() == 0 || value > stack.Peek())
            {
                stack.Push(value);
            }
            else
            {
                var temp = stack.Pop();
                SortedInsert(stack, value);
                stack.Push(temp);
            }
        }

        public static void ReversStack(LinkedListStack stack)
        {
            if(stack.Size() == 0)
            {
                return;
            }
            else
            {
                var temp = stack.Pop();
                ReversStack(stack);
                stack.InsertAtBottom(temp);
            }
        }

        //public static void Main(string[] args)
        //{
        //    var stack = new LinkedListStack();
        //    stack.Push(5);
        //    stack.Push(2);
        //    stack.Push(7);
        //    stack.Push(1);
        //    stack.Push(9);
        //    SortStack(stack);
        //    stack.Print();
        //    Console.WriteLine();
        //    ReversStack(stack);
        //    stack.Print();
        //}
    }
}
