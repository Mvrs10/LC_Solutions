namespace MaximumDotProductOfTwoSubsequences;

internal class Program
{
    private static int MaxDotProduct(int[] nums1, int[] nums2)
    {
        int m = nums1.Length;
        int n = nums2.Length;

        int[,] dp = new int[m + 1, n + 1];

        const int NEG_INF = -1_000_000_000;

        for (int i = 0; i <= m; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                dp[i, j] = NEG_INF;
            }
        }

        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                int pair = nums1[i - 1] * nums2[j - 1];

                int usePair = Math.Max(pair, pair + dp[i - 1, j - 1]);

                dp[i, j] = Math.Max(usePair, Math.Max(dp[i - 1, j], dp[i, j - 1]));
            }
        }

        return dp[m, n];
    }

    static void Main(string[] args)
    {
        int[] nums1 = [2, 1, -2, 5];
        int[] nums2 = [3, 0, -6];

        int result = MaxDotProduct(nums1, nums2);

        Console.WriteLine(result);
    }
}
