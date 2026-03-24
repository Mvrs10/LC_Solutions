namespace MaximumNonNegativeProductInAMatrix;

internal class Program
{
    private static int MaxProductPath(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int MOD = 1_000_000_007;

        long[,] maxDp = new long[m, n];
        long[,] minDp = new long[m, n];

        maxDp[0, 0] = grid[0][0];
        minDp[0, 0] = grid[0][0];

        for (int i = 1; i < m; i++)
        {
            maxDp[0, i] = maxDp[0, i - 1] * grid[0][i];
            minDp[0, i] = maxDp[0, i];
        }

        for (int i = 1; i < n; i++)
        {
            maxDp[i, 0] = maxDp[i - 1, 0] * grid[i][0];
            minDp[i, 0] = maxDp[i, 0];
        }

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                long val = grid[i][j];

                long a = maxDp[i - 1, j] * val;
                long b = minDp[i - 1, j] * val;
                long c = maxDp[i, j - 1] * val;
                long d = minDp[i, j - 1] * val;

                maxDp[i, j] = Math.Max(Math.Max(a, b), Math.Max(c, d));
                minDp[i, j] = Math.Min(Math.Min(a, b), Math.Min(c, d));
            }
        }

        long result = maxDp[m - 1, n - 1];
        if (result < 0) return -1;

        return (int)(result % MOD);
    }

    static void Main(string[] args)
    {
        int[][] grid = [[1, -2, 1], [1, -2, 1], [3, -4, 1]];
        int result = MaxProductPath(grid);

        Console.WriteLine(result);
    }
}
