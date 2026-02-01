namespace DivideAnArrayIntoSubarraysWithMinimumCost1;

internal class Program
{
    private static int MinimumCost(int[] nums)
    {
        int n = nums[0];
        nums[0] = 50;

        Array.Sort(nums);

        return n + nums[0] + nums[1];
    }

    static void Main(string[] args)
    {
        int[] nums = [10, 3, 1, 1];
        int result = MinimumCost(nums);
        Console.WriteLine(result);
    }
}
