using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class Search
    {
        public static int BinarySearchRecursive(int[] a, int key, int low, int high)
        {
            if (low > high) throw new InvalidOperationException("DesiredValueNoExist");

            var mid = (low + high) / 2;
            if(a[mid] == key)
            {
                return mid;
            }
            else if(a[mid] < key)
            {
                return BinarySearchRecursive(a, key, mid + 1, high);
            }
            else
            {
                return BinarySearchRecursive(a, key, low, mid - 1);
            }
        }

        //public static void Main(string[] args)
        //{
        //    var arr = new int[]
        //    {
        //        2, 3, 5, 7, 9, 12, 15
        //    };
        //    var result = BinarySearchRecursive(arr, 9, 0, arr.Length);
        //    Console.WriteLine(result);
        //}
    }
}
