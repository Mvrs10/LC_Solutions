namespace IncrementSubmatricesByOne;

internal class Program
{
    static private int[][] RangeAddQueries_BruteForce(int n, int[][] queries)
    {
        int[][] mat = new int[n][];
        for (int i = 0; i < n; i++)
        {
            mat[i] = new int[n];
        }

        foreach (int[] q in queries)
        {
            int row1 = q[0], col1 = q[1], row2 = q[2], col2 = q[3];
            for (int i = row1; i <= row2; i++)
            {
                for (int j = col1; j <= col2; j++)
                {
                    mat[i][j]++;
                }
            }
        }
        return mat;
    }

    static private int[][] RangeAddQueries(int n, int[][] queries)
    {
        int[][] flag = new int[n+1][];
        for (int r = 0; r < n + 1; r++)
        {
            flag[r] = new int[n + 1];
        }

        foreach (int[] q in queries)
        {
            int r1 = q[0], c1 = q[1];
            int r2 = q[2], c2 = q[3];

            flag[r1][c1] += 1;
            flag[r1][c2 +1] -= 1;
            flag[r2 + 1][c1] -= 1;
            flag[r2 + 1][c2 + 1] += 1;
        }

        for (int r = 0; r < n + 1; r++)
        {
            for (int c = 1; c < n + 1; c++)
            {
                flag[r][c] += flag[r][c - 1];
            }
        }

        for (int c = 0; c < n + 1; c++)
        {
            for (int r = 1; r < n + 1; r++)
            {
                flag[r][c] += flag[r - 1][c];
            }
        }

        int[][] result = new int[n][];
        for(int r = 0; r < n; r++)
        {
            result[r] = new int[n];
            for(int c = 0; c < n; c++)
            {
                result[r][c] = flag[r][c];
            }
        }

        return result;
    }
    static void Main(string[] args)
    {
        int[][] q1 = [[1, 1, 2, 2], [0, 0, 1, 1]];
        int[][] result = RangeAddQueries_BruteForce(3, q1);
        foreach (int[] r in result)
        {
            foreach (int c in r)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("-------------------");
        result = RangeAddQueries(3, q1);
        foreach (int[] r in result)
        {
            foreach (int c in r)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();
        }
    }
}
