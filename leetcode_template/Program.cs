using System.Linq;
using System;

public class LeetCodeTask
{
    public static void Main()
    {

    }
}

public class WhichAreIn
{
    public static string[] inArray(string[] array1, string[] array2)
    {
        string[] array3 = new string[0];
        for (int i = 0; i < array1.Length - 1; i++)
        {
            for (int j = 0; i < array2.Length - 1; i++)
            {
                if ((array2[j].Contains(array1[i])) && !(array3.Any(array1[i].Contains)))
                {
                    array3[array3.Length] = array1[i];
                }
            }
        }
        return array3;
    }
}
