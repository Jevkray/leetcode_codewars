using System.Linq;
using System;

public class LeetCodeTask
{
    public static void Main()
    {
        WhichAreIn.inArray(new string[] { "arp", "live", "strong" }, new string[] { "arp", "live", "strong" });
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
                    array3[0] = array1[0];
                }
            }
        }
        return array3;
    }
}
