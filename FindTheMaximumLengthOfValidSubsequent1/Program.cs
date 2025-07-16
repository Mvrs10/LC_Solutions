namespace FindTheMaximumLengthOfValidSubsequent1;

internal class Program
{
    private static int MaximumLength(int[] nums)
    {
        // dp[e,o]: max length counts with even and odd in 4 patterns
        int[,] dp = new int[2, 2]; // [EE, OE; EO, OO]
        int max = 0;

        foreach (int n in nums)
        {
            int parity = n % 2;

            int prevE = dp[0, parity];
            int prevO = dp[1, parity];

            dp[parity, 0] = prevE + 1; // EE || OE
            dp[parity, 1] = prevO + 1; // EO || OO

            max = Math.Max(max, Math.Max(dp[parity, 0], dp[parity, 1]));
        }
        return max;
    }
    static void Main(string[] args)
    {
        int[] nums1 = [1, 2, 3, 4];
        int[] nums2 = [1, 2, 1, 1, 2, 1, 2];
        int[] nums3 = [1, 3];

        int result = MaximumLength(nums1);
        Console.WriteLine(result);
        result = MaximumLength(nums2);
        Console.WriteLine(result);
        result = MaximumLength(nums3);
        Console.WriteLine(result);
    }
}
