using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Sort
    {
        public static int Partition01(int[] arr)
        {
            var left = 0;
            var right = arr.Length - 1;
            int count = 0;

            while(left < right)
            {
                while (arr[left] == 0)
                {
                    left += 1;
                }
                while (arr[right] == 1)
                {
                    right -= 1;
                }

                if (left < right)
                {
                    Swap(arr, left, right);
                    count++;
                }
            }

            return count;
        }

        public static void Partion012(int[] arr)
        {
            var left = 0;
            var right = arr.Length - 1;
            var index = 0;
            while(index <= right)
            {
                if(arr[index] == 0)
                {
                    Swap(arr, index, left);
                    index += 1;
                    left += 1;
                }
                else if(arr[index] == 2)
                {
                    Swap(arr, index, right);
                    right -= 1;
                }
                else
                {
                    index++;
                }
            }
        }

        private static void Swap(int[] arr, int origin, int target)
        {
            var temp = arr[target];
            arr[target] = arr[origin];
            arr[origin] = temp;
        }

        //public static void Main(string[] args)
        //{
        //    var arr = new int[]
        //    {
        //        0, 1, 1, 0, 0, 1, 0, 1, 0
        //    };
        //    var swapCount = Partition01(arr);
        //    Console.WriteLine("count: " + swapCount);
        //    foreach(var value in arr)
        //    {
        //        Console.Write(value + " ");
        //    }
        //    Console.WriteLine();

        //    var arr2 = new int[]
        //    {
        //        2, 1, 0, 2, 0, 0, 1, 0, 2
        //    };
        //    Partion012(arr2);
        //    foreach (var value in arr2)
        //    {
        //        Console.Write(value + " ");
        //    }
        //}
    }
}
