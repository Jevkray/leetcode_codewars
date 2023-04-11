public class LeetCodeTask48
{
    public static void Main()
    {
        Obj obj = new Obj();
        obj.ints = (new int[3][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } });
        Solution.Rotate(obj.ints);
        
    }
    public class Obj { 
        public int[][] ints;
    }

    public static class Solution
    {
        public static void Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - (i + 1); j++)
                {
                    int origin = matrix[i][j];
                    matrix[i][j] = matrix[n - (j + 1)][i];
                    matrix[n - (j + 1)][i] = matrix[n - (i + 1)][n - (j + 1)];
                    matrix[n - (i + 1)][n - (j + 1)] = matrix[j][n - (i + 1)];
                    matrix[j][n - (i + 1)] = origin;
                }
            }
        }
    }
}
//Первая Medium задача на leetcode
