namespace CountUnguardedCellsInTheGrid;

internal class Program
{
    private static int CountUnguarded_v1(int m, int n, int[][] guards, int[][] walls)
    {
        char[,] grid = new char[m, n];

        foreach (int[] w in walls)
        {
            grid[w[0], w[1]] = 'W';
        }

        foreach (int[] g in guards)
        {
            grid[g[0], g[1]] = 'G';
        }

        int[][] directions = [[0, 1], [0, -1], [1, 0], [-1, 0]];

        foreach (int[] g in guards)
        {
            int x = g[0];
            int y = g[1];

            foreach (int[] d in directions)
            {
                int curX = x + d[0];
                int curY = y + d[1];

                while(curX >= 0 && curX < m && curY >= 0 && curY < n && grid[curX, curY] != 'G' && grid[curX,curY] != 'W')
                {
                    if (grid[curX, curY] == '\0')
                        grid[curX, curY] = 'R';
                    curX += d[0];
                    curY += d[1];
                }
            }
        }

        int unguarded = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i, j] == '\0')
                    unguarded++;
            }
        }

        return unguarded;
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
