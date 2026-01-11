namespace MinimumASCIIDeleteSumForTwoStrings;

internal class Program
{
    static int MinimumDeleteSum(string s1, string s2)
    {
        int m = s1.Length, n = s2.Length;
        int[,] dp = new int[m + 1, n + 1];

        int s1Sum = 0;
        foreach (char c in s1)
        {
            s1Sum += c;
        }

        int s2Sum = 0;
        foreach (char c in s2)
        {
            s2Sum += c;
        }

        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (s1[i - 1] == s2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + s1[i - 1];
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }

        return s1Sum + s2Sum - 2 * dp[m, n];

    }
    static void Main(string[] args)
    {
        string s1 = "sea";
        string s2 = "eat";

        int result = MinimumDeleteSum(s1, s2);
        Console.WriteLine(result);
    }
}
