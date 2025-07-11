namespace RescheduleMeetingsForMaxFreeTime1;

internal class Program
{
    private static int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime)
    {
        int meetings = startTime.Length;
        int[] gaps = new int[meetings + 1];

        gaps[0] = startTime[0];
        gaps[meetings] = eventTime - endTime[meetings - 1];

        for (int i = 1; i < meetings; i++)
        {
            gaps[i] = startTime[i] - endTime[i - 1];
        }

        int freeTime = 0;
        int windowSum = 0;
        for (int i = 0; i < gaps.Length; i++) // Consecutive gaps
        {
            windowSum += gaps[i]; // Build the window            
            if (i >= k + 1) windowSum -= gaps[i - (k+1)]; // Slide the window
            if (i >= k) freeTime = Math.Max(freeTime, windowSum); // Update max
        }
        return freeTime;
    }
    static void Main(string[] args)
    {
        int eventTime = 10;
        int[] startTime = [0, 2, 9];
        int[] endTime = [1, 4, 10];
        int k = 1;

        int result = MaxFreeTime(eventTime, k, startTime, endTime);
        Console.WriteLine(result);
    }
}
