namespace LongestBalancedSubarray1;

internal class Program
{
    private static int LongestBalanced(int[] nums)
    {
        int n = nums.Length;
        int max = 0;

        for (int i = 0; i < n; i++)
        {
            HashSet<int> evens = new HashSet<int>();
            HashSet<int> odds = new HashSet<int>();

            for (int j = i; j < n; j++)
            {
                if ((nums[j] & 1) == 1)
                {
                    odds.Add(nums[j]);
                }
                else
                {
                    evens.Add(nums[j]);
                }

                if (evens.Count == odds.Count)
                {
                    max = Math.Max(max, j - i + 1);
                }
            }
        }

        return max;
    }

    static void Main(string[] args)
    {
        int[] numss = [1, 2, 3, 2];
        int r = LongestBalanced(numss);
        int[] nums1 = [2, 5, 4, 3];
        int[] nums2 = [3, 2, 2, 5, 4];
        int[] nums3 = [1, 2, 3, 2];
        int[][] nnums = [nums1, nums2, nums3];

        foreach (int[] nums in nnums)
        {
            int result = LongestBalanced(nums);
            Console.WriteLine(result);
        }
    }
}
