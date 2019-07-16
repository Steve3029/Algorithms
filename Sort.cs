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
                    var temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    count++;
                }
            }

            return count;
        }

        public static void Main(string[] args)
        {
            var arr = new int[]
            {
                0, 1, 1, 0, 0, 1, 0, 1, 0
            };
            var swapCount = Partition01(arr);
            Console.WriteLine("count: " + swapCount);
            foreach(var value in arr)
            {
                Console.Write(value + " ");
            }
        }
    }
}
