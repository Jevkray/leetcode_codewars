using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public class CWTask
{
    public static void Main()
    {
        Console.WriteLine(RomanNumerals.FromRoman("XI"));
    }
}

public class RomanNumerals
{
    public static string ToRoman(int n)
    {
        return "";
    }
    ////////////////////////////////////////////////////////////////
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