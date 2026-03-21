namespace FlipSquareSubmatrixVertically;

internal class Program
{
    private static int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k)
    {
        for (int i = 0; i < k / 2; i++)
        {
            for (int j = 0; j < k; j++)
            {
                int temp = grid[x + i][y + j];
                grid[x + i][y + j] = grid[x + k - i - 1][y + j];
                grid[x + k - i - 1][y + j] = temp;
            }
        }

        return grid;
    }
    static void Main(string[] args)
    {
        int[][] grid = grid = [[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16]];
        int x = 1, y = 0, k = 3;

        int[][] result = ReverseSubmatrix(grid, x, y, k);
        foreach (int[] row in result)
        {
            foreach (int col in row)
            {
                Console.Write(col+ " ");
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
