namespace PathsInMatrixWhoseSumIsDivisibleByK;

internal class Program
{
    private static int NumberOfPaths(int[][] grid, int k)
    {
        const int MOD = 1_000_000_007;
        int m = grid.Length;
        int n = grid[0].Length;
        int[,,] dp = new int[m, n, k];

        dp[0, 0, grid[0][0] % k] = 1;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int r = 0; r < k; r++)
                {
                    if (i == 0 && j == 0) continue;

                    int newR = (r + grid[i][j]) % k;
                    int paths = 0;

                    if (i > 0)
                        paths = (paths + dp[i - 1, j, r]) % MOD;
                    if (j > 0)
                        paths = (paths + dp[i, j - 1, r]) % MOD;

                    dp[i, j, newR] = (dp[i, j, newR] + paths) % MOD;
                }
            }
        }

        return dp[m - 1, n - 1, 0];
    }
    static void Main(string[] args)
    {
        int[][] matrix = [[7, 3, 4, 9], [2, 3, 6, 2], [2, 3, 7, 0]];
        int result = NumberOfPaths(matrix, 1);
        Console.WriteLine(result);
    }
}
