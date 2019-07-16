using System;
using System.Collections.Generic;

namespace Algorithms
{
    class StringSolutions
    {
        public static Dictionary<char, int> CountNumbersOfCharactar(string str)
        {
            var dict = new Dictionary<char, int>();
            var formatStr = str.ToLower().Replace(" ", "");
            var chars = formatStr.ToCharArray();
            foreach (var letter in chars)
            {
                if (dict.ContainsKey(letter))
                {
                    dict[letter] += 1;
                }
                else
                {
                    dict.Add(letter, 1);
                }
            }
            return dict;
        }

        //public static void Main(string[] args)
        //{
        //    var testStr = "I am the best developer in the world";
        //    var dict = CountNumbersOfCharactar(testStr);
        //    foreach (KeyValuePair<char, int> entry in dict)
        //    {
        //        Console.WriteLine($"{entry.Key}: {entry.Value}");
        //    }
        //}
    }
}
