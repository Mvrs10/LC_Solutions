namespace MinimumNumberOfSecondsToMakeMountainHeightZero;

internal class Program
{
    private static long MinNumberOfSeconds(int mountainHeight, int[] workerTimes)
    {
        long left = 1;
        long right = (long)workerTimes.Min() * mountainHeight * (mountainHeight + 1) / 2;

        while (left < right)
        {
            long mid = (left + right) / 2;

            if (CanFinish(mid, mountainHeight, workerTimes))
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }

    private static bool CanFinish(long time, int mountainHeight, int[] workerTimes)
    {
        long removed = 0;

        foreach (int t in workerTimes)
        {
            long x = (long)((Math.Sqrt(1 + 8.0 * time / t) - 1) / 2);
            removed += x;

            if (removed >= mountainHeight) return true;
        }

        return false;
    }

    static void Main(string[] args)
    {
        int mountainHeight = 4;
        int[] workerTimes = [2, 1, 1];

        long result = MinNumberOfSeconds(mountainHeight, workerTimes);

        Console.WriteLine(result);
    }
}
