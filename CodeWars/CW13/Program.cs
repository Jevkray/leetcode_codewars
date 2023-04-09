using System;
using System.Collections.Generic;

namespace Solution
{
    public class CWTask
    {
        public static void Main()
        {
            Console.WriteLine(Digitizer.Digitize(52349));
        }
    }
    public class Digitizer
    {
        public static long[] Digitize(long n)
        {
            long[] nArray = new long[] { };
            foreach (char c in n.ToString().ToArray().Reverse())
            {
                Array.Resize(ref nArray, nArray.Length + 1);
                nArray[nArray.Length - 1] = Convert.ToInt64(c.ToString());
            }
            return nArray;
        }
    }
}