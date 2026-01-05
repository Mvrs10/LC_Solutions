namespace MaximumMatrixSum;

internal class Program
{
    private static long MaxMatrixSum(int[][] matrix)
    {
        long sum = 0;
        int min = 100_006;
        int negativeCount = 0;
        bool hasZero = false;

        foreach (int[] row in matrix)
        {
            foreach (int col in row)
            {
                int v = col;
                if (v == 0) hasZero = true;
                if (v < 0)
                {
                    negativeCount++;
                    v = -v;                    
                }
                min = Math.Min(min, v);
                sum += v;
            }
        }

        return (negativeCount % 2 == 0 || hasZero) ? sum : sum - 2 * min;
    }

    static void Main(string[] args)
    {
        int[][] matrix = [[-1, 0, -1], [-2, 1, 3], [3, 2, 2]];
        long result = MaxMatrixSum(matrix);
        Console.WriteLine(result);
    }
}
