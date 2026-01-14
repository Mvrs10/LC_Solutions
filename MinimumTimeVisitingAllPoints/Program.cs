namespace MinimumTimeVisitingAllPoints;

internal class Program
{
    private static int MinTimeToVisitAllPoints(int[][] points)
    {
        int time = 0;
        for (int i = 1; i < points.Length; i++)
        {
            int x = Math.Abs(points[i][0] - points[i - 1][0]);
            int y = Math.Abs(points[i][1] - points[i - 1][1]);

            time += (x < y) ? y : x;
        }

        return time;
    }

    static void Main(string[] args)
    {
        int[][] points = [[1, 1], [3, 4], [-1, 0]];
        int result = MinTimeToVisitAllPoints(points);
        Console.WriteLine(result);
    }
}
