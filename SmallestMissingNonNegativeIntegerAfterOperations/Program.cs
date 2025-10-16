namespace SmallestMissingNonNegativeIntegerAfterOperations;

internal class Program
{
    private static int FindSmallestInteger(int[] nums, int value)
    {
        Dictionary<int, int> freq = new();
        foreach (int num in nums)
        {
            int r = num % value;
            if (num < 0)
                r = (r + value) % value;
            if (!freq.ContainsKey(r))
                freq[r] = 0;
            freq[r]++;
        }

        int mex = 0;
        while (true)
        {
            int r = mex % value;
            if (!freq.ContainsKey(r) || freq[r] == 0)
            {
                return mex;
            }
            freq[r]--;
            mex++;
        }
    }
    static void Main(string[] args)
    {
        int[] nums = [1, -10, 7, 13, 6, 8];
        int result = FindSmallestInteger(nums, 5);
        Console.WriteLine(result);
    }
}
