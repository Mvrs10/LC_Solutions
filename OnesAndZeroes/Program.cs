namespace OnesAndZeroes;

internal class Program
{
    private static int FindMaxForm(string[] strs, int m, int n)
    {
        int[,] dp = new int[m + 1, n + 1];

        foreach (string s in strs)
        {
            int zeros = 0, ones = 0;

            foreach (char c in s)
            {
                if (c == '0') zeros++;
                else ones++;
            }

            for (int i = m; i >= zeros; i--)
            {
                for (int j = n; j >= ones; j--)
                {
                    dp[i, j] = Math.Max(dp[i, j], dp[i - zeros, j - ones] + 1);
                }
            }
        }

        return dp[m, n];
    }

    static void Main(string[] args)
    {
        string[] strs = ["10", "0001", "111001", "1", "0"];
        int m = 5, n = 3;
        int result = FindMaxForm(strs, m, n);
        Console.WriteLine(result);
    }
}
