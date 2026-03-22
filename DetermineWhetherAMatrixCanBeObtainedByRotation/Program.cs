namespace DetermineWhetherAMatrixCanBeObtainedByRotation;

internal class Program
{
    private static bool FindRotation(int[][] mat, int[][] target)
    {
        for (int i = 0; i < 4; i++)
        {
            if(IsEqual(mat, target, mat.Length))
                return true;

            mat = RotateMatrix(mat);
        }

        return false;
    }

    private static int[][] RotateMatrix(int[][] mat)
    {
        int n = mat.Length;
        int[][] rotated = new int[n][];

        for (int i = 0; i < n; i++)
        {
            rotated[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                rotated[i][j] = mat[n - j - 1][i];
            }
        }

        return rotated;
    }

    private static bool IsEqual(int[][] mat, int[][] target, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (mat[i][j] != target[i][j]) return false;
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        int[][] mat = [[0, 1], [1, 0]];
        int[][] target = [[1, 0], [0, 1]];

        bool result = FindRotation(mat, target);
        Console.WriteLine(result);
    }
}
