namespace LargestSubmatrixWithRearrangements;

internal class Program
{
    private static int LargestSubmatrix(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;

        int[][] height = new int[m][];
        for (int i = 0; i < m; i++)
            height[i] = new int[n];

        for (int j = 0; j < n; j++)
        {
            height[0][j] = matrix[0][j];
            for (int i = 1; i < m; i++)
            {
                if (matrix[i][j] == 1)
                    height[i][j] = height[i - 1][j] + 1;
                else
                    height[i][j] = 0;
            }
        }

        int maxArea = 0;

        for (int i = 0; i < m; i++)
        {
            int[] row = (int[])height[i].Clone();

            Array.Sort(row);
            Array.Reverse(row);

            for (int j = 0; j < n; j++)
            {
                int area = row[j] * (j + 1);
                maxArea = Math.Max(maxArea, area);
            }
        }

        return maxArea;
    }

    static void Main(string[] args)
    {
        int[][] matrix = [[0, 0, 1], [1, 1, 1], [1, 0, 1]];
        int result = LargestSubmatrix(matrix);
        Console.WriteLine(result);
    }
}
