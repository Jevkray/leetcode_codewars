﻿public class LeetCodeTask3
{
    public static void Main()
    {
        Console.WriteLine(Solution.LengthOfLongestSubstring("dvdf"));
    }

    public class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            string sub = "";
            string currsub = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (!(currsub.Contains(s[i])))
                {
                    currsub += s[i];
                    if (sub.Length <= currsub.Length)
                    {
                        sub = currsub;
                    }
                }
                else if (currsub.Contains(s[i]))
                {
                    i = i - (currsub.Length - 1);
                    currsub = s[i].ToString();
                }
            }
            return sub.Length;
        }
    }
}
//Первая Medium задача на leetcode
