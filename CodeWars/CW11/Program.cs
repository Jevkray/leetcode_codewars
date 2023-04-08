using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class CWTask
{
    public static void Main()
    {
        Console.WriteLine(PrimeDecomp.factors(7775460));
    }
}
public static class PrimeDecomp
{

    public static System.String factors(int lst)
    {
        int dividor = 2;
        int[] dividors = new int[] { };
        string divString = "";

        while (true)
        {
            if (lst == 1)
            {
                return divString;
            }
            if (dividor == lst)
            {
                Array.Resize(ref dividors, dividors.Length + 1);
                dividors[dividors.Length - 1] = dividor;
                break;
            }
            if ((lst % dividor) == 0)
            {
                lst /= dividor;
                Array.Resize(ref dividors, dividors.Length + 1);
                dividors[dividors.Length - 1] = dividor;
                dividor = 2;
            }
            else if (lst % dividor != 0)
            {
                dividor++;
            }
        }

        int lastNum = 0;
        foreach (int i in dividors)
        {
            int countNums = dividors.Count(c => c == i);
            if ((countNums > 1) && (i != lastNum))
            {
                divString += "("+i+"**"+countNums+")";
            }
            if (countNums == 1)
            {
                divString += "("+i+")";
            }
            lastNum = i;
        }

        return divString;
    }
}

