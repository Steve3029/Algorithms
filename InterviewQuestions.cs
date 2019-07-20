using System;
using System.Collections.Generic;

public static class InterviewQuestions
{
    static void Main()
    {
        // balance parenthesis
        //var parenthesis = "{}[]{{[[()]]}}";
        //var result = CheckBalanceParenthesis(parenthesis);
        //Console.WriteLine(result);

        // fizz buzz
        //var fizzBuzzValues = new int[]
        //{
        //    3, 7, 16
        //};
        //var result = FizzBuzz(fizzBuzzValues);
        //foreach (var s in result)
        //{
        //    Console.Write(s + " ");
        //}

        // find the longest line
        var lines = new string[]
        {
            "opopopopop" + Environment.NewLine + "jkjkjkjkjkjk",
            "uiuiuiuiuiuiui" + Environment.NewLine + "mcndhd"

        };
        var result = GetLongestLines(lines);
        var values = result.Values;
        foreach (var s in values)
        {
            Console.WriteLine(s);
        }
    }

    static bool CheckBalanceParenthesis(string s)
    {
        var chars = s.ToCharArray();
        var stack1 = new Stack<char>();
        var stack2 = new Stack<char>();
        var symbolDict = new Dictionary<char, char>()
        {
            { '{', '}' },
            { '[', ']' },
            { '(', ')' },
            { '}', '{' },
            { ']', '[' },
            { ')', '(' },
        };

        foreach (var c in chars)
        {
            stack1.Push(c);
        }

        while (stack1.Count != 0)
        {
            var curr = stack1.Pop();
            if (stack2.Count > 0 && curr == symbolDict[stack2.Peek()])
            {
                stack2.Pop();
            }
            else
            {
                stack2.Push(curr);
            }
        }

        if (stack2.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static IList<string> FizzBuzz(int[] values)
    {
        var result = new List<string>();
        var A = values[0];
        var B = values[1];
        var N = values[2];

        for (var i = 0; i <= N; i++)
        {
            if (i % A == 0 && i % B == 0)
            {
                result.Add("F" + B);
            }
            else if (i % A == 0)
            {
                result.Add("F");
            }
            else if (i % B == 0)
            {
                result.Add(B.ToString());
            }
            else if (i % N == 0)
            {
                result.Add(N.ToString());
            }
            else
            {
                result.Add(i.ToString());
            }
        }
        return result;
    }

    public static IDictionary<int, string> GetLongestLines(string[] lines)
    {
        var dict = new Dictionary<int, string>();
        for (var i = 0; i < lines.Length; i++)
        {
            var sentences = lines[i].Split(Environment.NewLine);
            var sizeOfSentence = sentences[0].Length;
            dict.Add(i, sentences[0]);
            foreach (var sentence in sentences)
            {
                if (sentence.Length > sizeOfSentence)
                {
                    dict[i] = sentence;
                }
            }
        }
        return dict;
    }
}