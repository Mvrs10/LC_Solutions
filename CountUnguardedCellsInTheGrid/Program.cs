namespace CountUnguardedCellsInTheGrid;

internal class Program
{
    private static int MoveHorizontallyAndCountGuarded(char[,] grid, int x, int y, int direction)
    {
        int guardedCell = 0;
        int currentY = y + direction;

        while (currentY >= 0 && currentY < grid.GetLength(1))
        {
            char cell = grid[x, currentY];

            if (cell == 'W')
                break;
            if (cell != 'G' && cell != 'R')
            {
                grid[x, currentY] = 'R';
                guardedCell++;
            }

            currentY += direction;
        }

        return guardedCell;
    }

    private static int MoveVerticallyAndCountGuarded(char[,] grid, int x, int y, int direction)
    {
        int guardedCell = 0;
        int currentX = x + direction;

        while (currentX >= 0 && currentX < grid.GetLength(0))
        {
            char cell = grid[currentX, y];

            if (cell == 'W')
                break;
            if (cell != 'G' && cell != 'R')
            {
                grid[currentX, y] = 'R';
                guardedCell++;
            }

            currentX += direction;
        }

        return guardedCell;
    }
    private static int CountUnguarded_v1(int m, int n, int[][] guards, int[][] walls)
    {
        char[,] grid = new char[m, n];
        int guarded = 0;

        foreach (int[] w in walls)
        {
            grid[w[0], w[1]] = 'W';
        }

        foreach (int[] g in guards)
        {
            grid[g[0], g[1]] = 'G';
        }

        foreach (int[] g in guards)
        {
            guarded += MoveHorizontallyAndCountGuarded(grid, g[0], g[1], 1);
            guarded += MoveHorizontallyAndCountGuarded(grid, g[0], g[1], -1);
            guarded += MoveVerticallyAndCountGuarded(grid, g[0], g[1], 1);
            guarded += MoveVerticallyAndCountGuarded(grid, g[0], g[1], -1);
        }

        return grid.Length - guarded - guards.Length - walls.Length;
    }

    private static int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
    {
        char[,] grid = new char[m, n];

        foreach (var g in guards)
            grid[g[0], g[1]] = 'G';

        foreach (var w in walls)
            grid[w[0], w[1]] = 'W';

        for (int i = 0; i < m; i++)
        {
            bool guarded = false;
            for (int j = 0; j < n; j++)
            {
                if (grid[i, j] == 'W') guarded = false;
                else if (grid[i, j] == 'G') guarded = true;
                else if (guarded) grid[i, j] = 'R';
            }

            guarded = false;
            for (int j = n - 1; j >= 0; j--)
            {
                if (grid[i, j] == 'W') guarded = false;
                else if (grid[i, j] == 'G') guarded = true;
                else if (guarded) grid[i, j] = 'R';
            }
        }

        for (int j = 0; j < n; j++)
        {
            bool guarded = false;
            for (int i = 0; i < m; i++)
            {
                if (grid[i, j] == 'W') guarded = false;
                else if (grid[i, j] == 'G') guarded = true;
                else if (guarded) grid[i, j] = 'R';
            }

            guarded = false;
            for (int i = m - 1; i >= 0; i--)
            {
                if (grid[i, j] == 'W') guarded = false;
                else if (grid[i, j] == 'G') guarded = true;
                else if (guarded) grid[i, j] = 'R';
            }
        }

        int unguarded = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i, j] == '\0') unguarded++;
            }
        }

        return unguarded;
    }
    static void Main(string[] args)
    {
        int m = 4, n = 6;
        int[][] guards = [[0, 0], [1, 1], [2, 3]];
        int[][] walls = [[0, 1], [2, 2], [1, 4]];

        int result = CountUnguarded_v1(m, n, guards, walls);
        Console.WriteLine(result);

        result = CountUnguarded(m, n, guards, walls);
        Console.WriteLine(result);
    }
}
