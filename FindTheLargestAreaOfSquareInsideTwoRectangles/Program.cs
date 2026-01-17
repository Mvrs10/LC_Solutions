using System.Runtime.CompilerServices;

namespace FindTheLargestAreaOfSquareInsideTwoRectangles;

internal class Program
{
    private static long LargestSquareArea(int[][] bottomLeft, int[][] topRight)
    {
        long maxArea = 0;

        for (int i = 0; i < bottomLeft.Length; i++)
        {
            for (int j = 0; j < topRight.Length; j++)
            {
                if (i == j) continue;

                int left = Math.Max(bottomLeft[i][0], bottomLeft[j][0]);
                int bottom = Math.Max(bottomLeft[i][1], bottomLeft[j][1]);
                int right = Math.Min(topRight[i][0], topRight[j][0]);
                int top = Math.Min(topRight[i][1], topRight[j][1]);

                int w = right - left;
                int l = top - bottom;

                if (w > 0 && l > 0)
                {
                    long s = Math.Min(w, l);
                    maxArea = Math.Max(maxArea, s * s);
                }
            }
        }

        return maxArea;
    }

    static void Main(string[] args)
    {
        int[][] bottomLeft = [[1, 1], [3, 3], [3, 1]];
        int[][] topRight = [[2, 2], [4, 4], [4, 2]];

        long result = LargestSquareArea(bottomLeft, topRight);
        Console.WriteLine(result);
    }
}
