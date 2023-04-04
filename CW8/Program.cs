using System;

public class CWTask
{
    public static void Main()
    {
        Console.WriteLine(Kata.IsIsogram("moOse"));
    }
}

public class Kata
{
    public static bool IsIsogram(string str)
    {
        string subStr = "";
        str = str.ToLower();
        foreach (char s in str)
        {
            if (!(subStr.Contains(s)))
            {
                subStr += s;
            }
            else if (subStr.Contains(s))
            {
                return false;
            }
        }
        return true;
    }
}
