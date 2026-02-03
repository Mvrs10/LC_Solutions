namespace TrionicArray1;

internal class Program
{
    private static bool IsTrionic(int[] nums)
    {
        int n = nums.Length;
        if (n < 4 || nums[0] >= nums[1]) return false;

        int i = 2;
        while (i < n)
        {
            if (nums[i] == nums[i - 1])
                return false;

            if (nums[i] < nums[i - 1])
                break;

            i++;
        }

        if (i >= n - 1) return false;

        while (i < n)
        {
            if (nums[i] == nums[i - 1])
                return false;

            if (nums[i] > nums[i - 1])
                break;

            i++;
        }

        if (i > n - 1) return false;

        while (i < n)
        {
            if (nums[i] <= nums[i - 1])
                return false;

            i++;
        }

        return true;
    }

    static void Main(string[] args)
    {
        int[] nums1 = [1, 3, 5, 4, 2, 6];
        int[] nums2 = [2, 1, 3];
        int[] nums3 = [1, 3, 2, 5];
        int[] nums4 = [1, 4, 4, 4, 2, 1];

        int[][] testCases = [nums1, nums2, nums3, nums4];

        foreach (int[] c in  testCases)
        {
            Console.WriteLine(IsTrionic(c));
        }
    }
}
