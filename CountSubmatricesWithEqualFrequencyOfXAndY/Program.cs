namespace CountSubmatricesWithEqualFrequencyOfXAndY;

internal class Program
{
    private static int NumberOfSubmatrices(char[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;

        int[,] prefX = new int[m + 1, n + 1];
        int[,] prefY = new int[m + 1, n + 1];
        int validSubmatrices = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int x = grid[i][j] == 'X' ? 1 : 0;
                int y = grid[i][j] == 'Y' ? 1 : 0;

                prefX[i + 1, j + 1] = x + prefX[i, j + 1] + prefX[i + 1, j] - prefX[i, j];
                prefY[i + 1, j + 1] = y + prefY[i, j + 1] + prefY[i + 1, j] - prefY[i, j];

                if (prefX[i + 1, j + 1] == prefY[i + 1, j + 1] && prefX[i + 1, j + 1] > 0)
                    validSubmatrices++;
            }
        }

        return validSubmatrices;
    }

    static void Main(string[] args)
    {
        char[][] grid = [['X', 'Y', '.'], ['Y', '.', '.']];

        int result = NumberOfSubmatrices(grid);
        Console.WriteLine(result);
    }
}
