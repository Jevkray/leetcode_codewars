using System;
using System.Collections;

namespace Solution
{
    public class CWTask
    {
        public static void Main()
        {
            Console.WriteLine(Kata.XO("xxoo"));
        }
    }
    public class Kata
    {
        public static bool XO(string input)
        {
            int xCount = 0;
            int oCount = 0;
            input = input.ToLower();
            foreach (char c in input)
            {
                if (c == 'x')
                {
                    xCount++;
                }
            }
            foreach (char c in input)
            {
                if (c == 'x')
                {
                    oCount++;
                }
            }
            return (oCount == xCount);
        }
    }
}