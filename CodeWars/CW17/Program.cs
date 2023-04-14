using System;
using System.Collections;

namespace Solution
{
    public class CWTask
    {
        public static void Main()
        {
            Console.WriteLine(Kata.DuplicateCount("AA12BB"));
        }
    }

    public class Kata
    {
        public static int DuplicateCount(string str)
        {
            str = str.ToLower();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                int s = str.Count(c.Equals);
                if (s > 1)
                {
                    str = str.Replace(c.ToString(), "");
                    count++;
                    i--;
                }
            }
            return count;
        }
    }
}