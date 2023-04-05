public class Solution
{
    public static void Main()
    {
        Console.WriteLine(FindMedianSortedArrays(new int[] {1,5,6}, new int[] { 1, 5, 6 }));
    }
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] nums3 = nums1.Concat(nums2).ToArray();
        int[] sortedNums = SortArray(nums3, 0, nums3.Length - 1);
        int mid = sortedNums.Length / 2;
        if (sortedNums.Length % 2 == 0)
        {
            return (Convert.ToDouble(sortedNums[mid]) + Convert.ToDouble(sortedNums[mid - 1])) / 2;
        }
        return sortedNums[mid];
    }

    public static int[] SortArray(int[] nums3, int leftIndex, int rightIndex)
    {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = nums3[leftIndex];
        while (i <= j)
        {
            while (nums3[i] < pivot)
            {
                i++;
            }

            while (nums3[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                int temp = nums3[i];
                nums3[i] = nums3[j];
                nums3[j] = temp;
                i++;
                j--;
            }
        }

        if (leftIndex < j)
            SortArray(nums3, leftIndex, j);
        if (i < rightIndex)
            SortArray(nums3, i, rightIndex);

        return nums3;
    }
}