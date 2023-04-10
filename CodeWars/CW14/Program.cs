using System;

namespace Solution
{
    public class CWTask
    {
        public static void Main()
        {
            Console.WriteLine(Kata.IsPrime(52341));
        }
    }

    public static class Kata
    {
        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Convert.ToInt32(Math.Sqrt(n)); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}