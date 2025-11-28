namespace MaximumSubarraySumWithLengthDivisibleByK;

internal class Program
{
    private static long MaxSubarraySum(int[] nums, int k)
    {
        int n = nums.Length;
        long[] prefixSums = new long[n];
        prefixSums[0] = nums[0];

        for (int i = 1; i < n; i++)
        {
            prefixSums[i] = prefixSums[i - 1] + nums[i];
        }

        long sum = long.MinValue;

        for (int i = 1; i <= n; i++)
        {
            if (i % k != 0)
                continue;

            for (int j = 0; j + i - 1 < n; j++)
            {
                long newSum = (j == 0) ? prefixSums[j + i - 1] - 0 : prefixSums[j + i - 1] - prefixSums[j - 1];
                sum = Math.Max(sum, newSum);
            }
        }

        return sum;
    }

    private static long MaxSubarraySum_v2(int[] nums, int k)
    {
        int n = nums.Length;
        long[] prefixSums = new long[n + 1];

        for (int i = 1; i <= n; i++)
            prefixSums[i] = prefixSums[i - 1] + nums[i - 1];

        long ans = long.MinValue;

        long[] best = Enumerable.Repeat(long.MaxValue, k).ToArray();

        for (int j = 0; j <= n; j++)
        {
            int r = j % k;
            if (best[r] != long.MaxValue)
                ans = Math.Max(ans, prefixSums[j] - best[r]);

            best[r] = Math.Min(best[r], prefixSums[j]);
        }

        return ans;
    }

    private static long MaxSubarraySum_v3(int[] nums, int k)
    {
        int n = nums.Length;
        long prefixSum = 0;
        long maxSum = long.MinValue;
        long[] kSum = new long[k];
        for (int i = 0; i < k; i++)
        {
            kSum[i] = long.MaxValue / 2;
        }
        kSum[k - 1] = 0;
        for (int i = 0; i < n; i++)
        {
            prefixSum += nums[i];
            maxSum = Math.Max(maxSum, prefixSum - kSum[i % k]);
            kSum[i % k] = Math.Min(kSum[i % k], prefixSum);
        }
        return maxSum;
    }

    static void Main(string[] args)
    {
        int[] nums = [1,2];
        int k = 1;
        long result = MaxSubarraySum(nums, k);
        Console.WriteLine(result);

        nums = [10, 20, 10, 5, 15];
        k = 4;
        result = MaxSubarraySum_v2(nums, k);
        Console.WriteLine(result);

        result = MaxSubarraySum_v3(nums, k);
        Console.WriteLine(result);
    }
}
