using System.Collections;

public class LeetCodeTask9
{
    public static void Main()
    {
        int x = 121;
        int x2 = -121;
        int x3 = 10;

        Console.WriteLine(Enumerable.SequenceEqual(x.ToString().ToCharArray(), x.ToString().ToCharArray().Reverse()));
        Console.WriteLine(IsPalindrome(x));

    }

    public static bool IsPalindrome(int x)
    {
        string xString = x.ToString();
        string revString = "";
        foreach (int i in xString.Reverse())
        {
            revString += Convert.ToChar(i);
        }
        if (revString == xString)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
