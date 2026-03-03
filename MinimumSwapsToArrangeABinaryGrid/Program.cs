namespace MinimumSwapsToArrangeABinaryGrid;

internal class Program
{
    private static int MinSwaps(int[][] grid)
    {
        int n = grid.Length;
        int[] rightMost = new int[n];

        for (int i = 0; i < n; i++)
        {
            int pos = -1;
            for (int j = n - 1; j >= 0; j--)
            {
                if (grid[i][j] == 1)
                {
                    pos = j;
                    break;
                }
            }
            rightMost[i] = pos;
        }

        int swaps = 0;

        for (int i = 0; i < n; i++)
        {
            int j = i;

            while (j < n && rightMost[j] > i)
                j++;

            if (j == n)
                return -1;

            while (j > i)
            {
                int temp = rightMost[j];
                rightMost[j] = rightMost[j - 1];
                rightMost[j - 1] = temp;

                swaps++;
                j--;
            }
        }

        return swaps;
    }

    static void Main(string[] args)
    {
        int[][] grid = [[0, 0, 1], [1, 1, 0], [1, 0, 0]];
        int result = MinSwaps(grid);
        Console.WriteLine(result);
    }
}
