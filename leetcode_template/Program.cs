using System.Linq;
using System;

public class LeetCodeTask
{
    public static void Main()
    {
        Console.WriteLine(string.Join(", ", (WhichAreIn.inArray(new string[] { "ar", "code", "war", "lively", "war" }, new string[] { "lively", "alive", "harp", "ar", "war", "desme" }))));
    }
}

public class WhichAreIn
{
    public static string[] inArray(string[] array1, string[] array2)
    {
        string[] array3 = new string[0];
        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                if ((array2[j].Contains(array1[i])) && !(array3.Any().Equals(array1[i])))
                {
                    Array.Resize(ref array3, array3.Length + 1);
                    array3[array3.Length - 1] = array1[i];
                    array3 = array3.Distinct().ToArray();
                }
            }
        }
        return array3;
    }
}
