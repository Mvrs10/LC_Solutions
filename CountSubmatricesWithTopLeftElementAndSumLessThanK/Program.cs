namespace CountSubmatricesWithTopLeftElementAndSumLessThanK;

internal class Program
{
    private static int CountSubmatrices(int[][] grid, int k)
    {
        int m = grid.Length;
        int n = grid[0].Length;

        int count = 0;
        int[,] prefix = new int[m, n];
        
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                prefix[i,j] = grid[i][j];

                if (i > 0) prefix[i, j] += prefix[i - 1, j]; 
                if (j > 0) prefix[i, j] += prefix[i, j - 1];
                if (i > 0 && j > 0) prefix[i, j] -= prefix[i - 1, j - 1];

                if (prefix[i,j] <= k)
                    count++;
            }
        }

        return count;
    }
    static void Main(string[] args)
    {
        int[][] grid = [[7, 6, 3], [6, 6, 1]];
        int k = 18;

        int result = CountSubmatrices(grid, k);
        Console.WriteLine(result);
    }
}
