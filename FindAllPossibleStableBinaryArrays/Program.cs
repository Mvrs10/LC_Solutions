namespace FindAllPossibleStableBinaryArrays;

internal class Program
{
    private static int NumberOfStableArrays(int zero, int one, int limit)
    {
        long MOD = 1_000_000_007;
        // dp[zeros_used][ones_used][last_digit_placed]
        long[,,] dp = new long[zero + 1, one + 1, 2];

        // Base Case: Arrays consisting of only a single block of 0s or 1s
        for (int i = 1; i <= Math.Min(zero, limit); i++)
        {
            dp[i, 0, 0] = 1;
        }
        for (int j = 1; j <= Math.Min(one, limit); j++)
        {
            dp[0, j, 1] = 1;
        }

        // Fill the DP table
        for (int i = 1; i <= zero; i++)
        {
            for (int j = 1; j <= one; j++)
            {

                // Case 1: Current block ends in 0
                // We must have come from a state that ended in 1
                for (int k = 1; k <= Math.Min(i, limit); k++)
                {
                    dp[i, j, 0] = (dp[i, j, 0] + dp[i - k, j, 1]) % MOD;
                }

                // Case 2: Current block ends in 1
                // We must have come from a state that ended in 0
                for (int k = 1; k <= Math.Min(j, limit); k++)
                {
                    dp[i, j, 1] = (dp[i, j, 1] + dp[i, j - k, 0]) % MOD;
                }
            }
        }

        return (int)((dp[zero, one, 0] + dp[zero, one, 1]) % MOD);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
