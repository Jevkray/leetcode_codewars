using System;
using System.Collections.Generic;
using System.Linq;

public class CWTask
{
    public static void Main()
    {
        Console.WriteLine(Kata.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
    }
}
public class Kata
{
    public static int FindEvenIndex(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int sum1 = 0;
            int sum2 = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (j < i)
                {
                    sum1 += arr[j];
                }
                if (j > i)
                {
                    sum2 += arr[j];
                }
            }
            if (sum1 == sum2)
            {
                return i;
            }
        }
        return -1;
    }
}