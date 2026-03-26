namespace EqualSumGridPartition1;

internal class Program
{
    private static bool CanPartitionGrid(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        long total = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                total += grid[i][j];
            }
        }

        if (total % 2 == 1) return false;

        long half = total / 2;
        long prefix = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                prefix += grid[i][j];
            }
            if (prefix == half) return true;
        }

        prefix = 0;
        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < m; i++)
            {
                prefix += grid[i][j];
            }
            if (prefix == half) return true;
        }

        return false;
    }
    static void Main(string[] args)
    {
        int[][] grid = [[1, 4], [2, 3]];
        bool result = CanPartitionGrid(grid);

        Console.WriteLine(result);
    }
}
