namespace AdjacentIncreasingSubarrayDetection1;

internal class Program
{
    private static bool HasIncreasingSubarrays(IList<int> nums, int k)
    {
        int n = nums.Count;
        if (2 * k > n) return false;

        bool IsIncreasing(int start)
        {
            for (int j = start; j < start + k - 1; j++)
            {
                if (nums[j] >= nums[j + 1]) return false;
            }
            return true;
        }

        for (int i = 0; i <= n - 2 * k; i++)
        {
            if (IsIncreasing(i) && IsIncreasing(i + k))
                return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        IList<int> nums = new List<int> { 2, 5, 7, 8, 9, 2, 3, 4, 3, 1 };
        Console.WriteLine(HasIncreasingSubarrays(nums, 3));
    }
}
