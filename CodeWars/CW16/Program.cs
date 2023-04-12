using System;
using System.Collections;

namespace Solution
{
    public class CWTask
    {
        public static void Main()
        {
            Console.WriteLine(Kata.CountCombinations(43, new int[] {  3, 7,8,9 }));
        }
    }

    public static class Kata
    {
        public static int CountCombinations(int money, int[] coins)
        {
            Array.Sort(coins);

            int[] table = new int[money + 1];
            table[0] = 1;

            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = coins[i]; j <= money; j++)
                {
                    table[j] += table[j - coins[i]];
                }
            }
            return table[money];
        }
    }
}