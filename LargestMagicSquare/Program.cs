namespace LargestMagicSquare;

internal class Program
{
    private static int LargestMagicSquare(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;

        int size = Math.Min(m, n);

        int[,] prefRow = new int[m, n + 1];
        int[,] prefCol = new int[m + 1, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                prefRow[i, j + 1] = prefRow[i,j] + grid[i][j];
                prefCol[i + 1, j] = prefCol[i,j] + grid[i][j];
            }
        }

        while (size > 1)
        {
            for (int i = 0; i <= m - size; i++)
            {
                for (int j = 0; j <= n - size; j++)
                {
                    int magicSum = prefRow[i, j + size] - prefRow[i,j];
                    bool isMagicSquare = true;

                    for (int k = 0; k < size; k++)
                    {
                        if (prefRow[i + k, j + size] - prefRow[i + k, j] != magicSum)
                        {
                            isMagicSquare = false;
                            break;
                        }
                    }

                    if (!isMagicSquare) continue;

                    for (int k = 0; k < size; k++)
                    {
                        if (prefCol[i + size, j + k] - prefCol[i, j + k] != magicSum)
                        {
                            isMagicSquare = false;
                            break;
                        }
                    }

                    if (!isMagicSquare) continue;

                    int diag1 = 0, diag2 = 0;
                    for (int k = 0; k < size; k++)
                    {
                        diag1 += grid[i + k][j + k];
                        diag2 += grid[i + k][j + size - k - 1];
                    }

                    if (diag1 == magicSum && diag2 == magicSum)
                        return size;
                }
            }
            size--;
        }

        return 1;
    }

    static void Main(string[] args)
    {
        int[][] grid = [[7, 1, 4, 5, 6], [2, 5, 1, 6, 4], [1, 5, 4, 3, 2], [1, 2, 7, 3, 4]];
        int result = LargestMagicSquare(grid);
        Console.WriteLine(result);
    }
}
