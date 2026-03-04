namespace SpecialPositionsInABinaryMatrix;

internal class Program
{
    private static int NumSpecial(int[][] mat)
    {
        int specialPos = 0;
        int m = mat.Length;
        int n = mat[0].Length;

        List<int[]> ones = new List<int[]>();
        int[] row = new int[m];
        int[] col = new int[n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i][j] == 1)
                {
                    ones.Add([i, j]);
                    row[i]++;
                    col[j]++;
                }
            }
        }

        foreach (int[] one in ones)
        {
            if (row[one[0]] == 1 && col[one[1]] == 1)
            {
                specialPos++;
            }
        }

        return specialPos;
    }

    static void Main(string[] args)
    {
        int[][] mat = [[1, 0, 0], [0, 0, 1], [1, 0, 0]];
        int result = NumSpecial(mat);
        Console.WriteLine(result);
    }
}
