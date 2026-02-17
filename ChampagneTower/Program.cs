namespace ChampagneTower;

internal class Program
{
    static double ChampagneTower(int poured, int query_row, int query_glass)
    {
        double[][] dp = new double[query_row + 2][];

        for (int i = 0; i <= query_row + 1; i++)
        {
            dp[i] = new double[i + 1];
        }

        dp[0][0] = poured;

        for (int r = 0; r <= query_row; r++)
        {
            for (int c = 0; c <= r; c++)
            {
                if (dp[r][c] > 1.0)
                {
                    double overflow = (dp[r][c] - 1.0) / 2.0;
                    dp[r + 1][c] += overflow;
                    dp[r + 1][c + 1] += overflow;
                    dp[r][c] = 1.0;
                }
            }
        }

        return Math.Min(1.0, dp[query_row][query_glass]);
    }

    static void Main(string[] args)
    {
        int poured = 1009, query_row = 33, query_glass = 17;
        double result = ChampagneTower(poured, query_row, query_glass);
        Console.WriteLine(result);
    }
}
