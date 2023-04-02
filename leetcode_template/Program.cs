using System.Linq;
using System;

public class LeetCodeTask
{
    public static void Main()
    {
        Console.WriteLine(string.Join(", ", (WhichAreIn.inArray(new string[] { "cod", "code", "wars", "ewar" }, new string[] { "lively", "alive", "harp", "sharp", "armstrong", "codewars" }))));
    }
}

public class WhichAreIn
{
    public static string[] inArray(string[] array1, string[] array2)
    {
        var x = array1.Where(s1 => array2.Any(s2 => s2.Contains(s1))).OrderBy(s => s).ToArray();
        return x;
    }
}

//Вывод один- учить LINQ