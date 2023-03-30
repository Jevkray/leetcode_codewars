public class LeetCodeTask14
{
    public static void Main()
    {
        string[] strs = new string[] { "abca", "aba", "aaab" };

        string answer = LongestCommonPrefix(strs);

        Console.WriteLine(answer);
    }

    public static string LongestCommonPrefix(string[] strs)
    {

        string minString = FindNumberOfMinLengthString(strs);

        for (int i = 0; i < strs.Length;)
        {
            int indexOfString = strs[i].IndexOf(minString);
            if (indexOfString == -1 || indexOfString > 0)
            {
                minString = minString[..^1];
            }
            if (indexOfString == 0)
            {
                i++;
            }
        }
        return minString;
    }

    public static string FindNumberOfMinLengthString(string[] strs)
    {
        int numberMinString = 0;

        for (int i = 0; i < strs.Length; i++)
        {
            if (strs[i].Length <= strs[numberMinString].Length)
            {
                numberMinString = i;
            }
        }
        return strs[numberMinString];
    }
}

