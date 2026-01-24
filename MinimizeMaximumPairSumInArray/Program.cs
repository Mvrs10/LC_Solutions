namespace MinimizeMaximumPairSumInArray;

internal class Program
{
    private static int MinPairSum(int[] nums)
    {
        Array.Sort(nums);
        int max = 0;
        int n = nums.Length;

        for (int i = 0; i < n/2; i++)
        {
            max = Math.Max(max, nums[i] + nums[n - 1 - i]);
        }

        return max;
    }

    static void Main(string[] args)
    {
        int[] nums = [3, 2, 5, 3];
        int result = MinPairSum(nums);
        Console.WriteLine(result);
    }
}
