namespace MaximumSideLengthOfASquareWithSumLessThanOrEqualToThreshold;

internal class Program
{
    private static int MaxSideLength(int[][] mat, int threshold)
    {
        int m = mat.Length;
        int n = mat[0].Length;

        int[,] prefRow = new int[m, n + 1];
        int[,] prefCol = new int[m + 1, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                prefRow[i, j + 1] = prefRow[i, j] + mat[i][j];
                prefCol[i + 1, j] = prefCol[i, j] + mat[i][j];
            }
        }

        int max = Math.Min(m, n);
        int s = 0;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i][j] > threshold) continue;

                int sum = 0;
                int k = 0;

                while (k < max && i + k < m && j + k < n)
                {
                    sum += (prefRow[i + k, j + k + 1] - prefRow[i + k, j])
                         + (prefCol[i + k + 1, j + k] - prefCol[i, j + k])
                         - mat[i + k][j + k];

                    if (sum > threshold) break;

                    s = Math.Max(s, k + 1);
                    k++;
                }
            }
        }

        return s;
    }
    static void Main(string[] args)
    {
        int[][] mat = [[1, 1, 3, 2, 4, 3, 2], [1, 1, 3, 2, 4, 3, 2], [1, 1, 3, 2, 4, 3, 2]];
        int threshold = 4;

        int result = MaxSideLength(mat, threshold);
        Console.WriteLine(result);
    }
}
