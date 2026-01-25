namespace MinimumDifferenceBetweenHighestandLowestofKScores;

internal class Program
{
    private static int MinimumDifferences(int[] nums, int k)
    {
        if (k == 1) return 0;

        Array.Sort(nums);
        int diff = 100000;
        for(int i = 0; i + k - 1 < nums.Length; i++)
        {
            diff = Math.Min(diff, nums[i + k - 1] - nums[i]);
        }

        return diff;
    }
    static void Main(string[] args)
    {
        int[] nums = [9, 4, 7, 1];
        int result = MinimumDifferences(nums, 2);
        Console.WriteLine(result);
    }
}
