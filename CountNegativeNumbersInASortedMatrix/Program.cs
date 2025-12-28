namespace CountNegativeNumbersInASortedMatrix;

internal class Program
{
    private static int CountNegatives(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;

        int r = m - 1;
        int c = 0;
        int negatives = 0;

        while(r >=0 && c < n)
        {
            if (grid[r][c] < 0)
            {
                negatives += (n - c);
                r--;
            }
            else
            {
                c++;
            }
        }

        return negatives;
    }

    static void Main(string[] args)
    {
        int[][] grid = [[4, 3, 2, -1], [3, 2, 1, -1], [1, 1, -1, -2], [-1, -1, -2, -3]];
        int result = CountNegatives(grid);
        Console.WriteLine(result);
    }
}
