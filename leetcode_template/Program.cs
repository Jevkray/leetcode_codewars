public class LeetCodeTask
{
    public static void Main()
    {
        int[] numbers = { 3, 2, 2, 3 };
        Console.WriteLine(Solution.RemoveElement( numbers , 3));
    }

    public static class Solution
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            foreach (int c in nums)
            {
                if (val == c)
                {
                    k++;
                }
            }
            return k;
        }
    }

}

