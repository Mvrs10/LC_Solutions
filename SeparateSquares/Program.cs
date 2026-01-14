namespace SeparateSquares;

internal class Program
{
    private static double SeparateSquares(int[][] squares)
    {
        double low = 0, high = 0, totalArea = 0;
        const double EPS = 1e-5;

        foreach (int[] square in squares)
        {
            double l = square[2];
            high = Math.Max(high, square[1] + l);
            totalArea += l * l;
        }

        double halfArea = totalArea / 2;

        while (high > low + EPS)
        {
            double mid = (high + low) / 2;
            if (GetLowArea(squares, mid) < halfArea)
                low = mid;
            else
                high = mid;
        }

        return high;
    }

    private static double GetLowArea(int[][] squares, double h)
    {
        double area = 0;
        foreach (int[] square in squares)
        {
            if (square[1] < h)
            {
                double s = square[2];
                area += (square[1] + square[2] < h) ? s * s : (h - square[1]) * s;
            }
        }

        return area;
    }
    static void Main(string[] args)
    {
        int[][] squares = [[0, 0, 1], [2, 2, 1]];
        double result = SeparateSquares(squares);
        Console.WriteLine(result);
    }
}
