namespace ConstructProductMatrix;

internal class Program
{
    private static int[][] ConstructProductMatrix(int[][] grid)
    {
        const int MOD = 12345;
        int n = grid.Length;
        int m = grid[0].Length;

        int[][] ans = new int[n][];
        for (int i = 0; i < n; i++)
        {
            ans[i] = new int[m];
        }

        int total = n * m;

        long[] prefixProducts = new long[total + 1];
        prefixProducts[0] = 1;

        int idx = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                prefixProducts[idx + 1] = (prefixProducts[idx] * grid[i][j]) % MOD;
                idx++;
            }
        }

        long suffixProduct = 1;

        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = m - 1; j >= 0; j--)
            {
                int index = i * m + j;
                ans[i][j] = (int)((prefixProducts[index] * suffixProduct) % MOD);
                suffixProduct = (suffixProduct * grid[i][j]) % MOD;
            }
        }

        return ans;
    }

    static void Main(string[] args)
    {
        int[][] grid = [[1, 2], [3, 4]];
        int[][] result = ConstructProductMatrix(grid);
        foreach (int[] row in result)
        {
            foreach (int col in row)
            {
                Console.WriteLine(col);
            }
        }
    }
}
