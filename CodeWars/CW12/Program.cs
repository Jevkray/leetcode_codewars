using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class CWTask
{
    public static void Main()
    {
        Console.WriteLine(RomanNumerals.ToRoman(59));
    }
}

public class RomanNumerals
{
    public static string ToRoman(int n)
    {
        if ((n > 0) && (n <= 4000))
        {
            string romanString = string.Empty;

            while (n > 0)
            {
                if (n >= 1000)
                {
                    n = n - 1000;
                    romanString += "M";
                }
                else if (n >= 900)
                {
                    n = n - 900;
                    romanString += "CM";
                }
                else if (n >= 500)
                {
                    n = n - 500;
                    romanString += "D";
                }
                else if (n >= 400)
                {
                    n = n - 400;
                    romanString += "CD";
                }
                else if (n >= 100)
                {
                    n = n - 100;
                    romanString += "C";
                }
                else if (n >= 90)
                {
                    n = n - 90;
                    romanString += "XC";
                }
                else if (n >= 50)
                {
                    n = n - 50;
                    romanString += "L";
                }
                else if (n >= 40)
                {
                    n = n - 40;
                    romanString += "XL";
                }
                else if (n >= 10)
                {
                    n = n - 10;
                    romanString += "X";
                }
                else if (n >= 9)
                {
                    n = n - 9;
                    romanString += "IX";
                }
                else if (n >= 5)
                {
                    n = n - 5;
                    romanString += "V";
                }
                else if (n >= 4)
                {
                    n = n - 4;
                    romanString += "IV";
                }
                else if (n >= 1)
                {
                    n = n - 1;
                    romanString += "I";
                }
            }
            return romanString;
        }
        else return "";
    }

    public static int FromRoman(string input)
    {
        int output = 0;

        foreach (char symbolInput in input)
        {
            output = checkFromRomanSymbol(symbolInput, output);
        }
        int minusOutput = checkComboFromRomanSymbol(input);

        return (output + minusOutput);
    }

    public static int checkFromRomanSymbol(char symbol, int output)
    {
        int value = 0;
        if (symbol == 'I')
        {
            value = 1;
        }
        if (symbol == 'V')
        {
            value = 5;
        }
        if (symbol == 'X')
        {
            value = 10;
        }
        if (symbol == 'L')
        {
            value = 50;
        }
        if (symbol == 'C')
        {
            value = 100;
        }
        if (symbol == 'D')
        {
            value = 500;
        }
        if (symbol == 'M')
        {
            value = 1000;
        }
        return (output + value);
    }

    public static int checkComboFromRomanSymbol(string input)
    {
        int value = 0;
        if ((input.Contains("IV")) || (input.Contains("IX")))
        {
            value -= 2;
        }
        if ((input.Contains("XL")) || (input.Contains("XC")))
        {
            value -= 20;
        }
        if ((input.Contains("CD")) || (input.Contains("CM")))
        {
            value -= 200;
        }
        return (value);
    }
}