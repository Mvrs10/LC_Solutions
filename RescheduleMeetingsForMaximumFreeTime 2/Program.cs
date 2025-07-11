namespace RescheduleMeetingsForMaximumFreeTime_2;

internal class Program
{
    private static int MaxFreeTime(int eventTime, int[] startTime, int[] endTime)
    {
        int n = startTime.Length;
        int[] gaps = new int[n + 1];

        gaps[0] = startTime[0];
        for (int i = 1; i < n; i++)
        {
            gaps[i] = startTime[i] - endTime[i - 1];
        }
        gaps[n] = eventTime - endTime.Last();

        int[] maxLeftSoFar = new int[n + 1];
        maxLeftSoFar[0] = gaps[0];
        for (int i = 1; i < gaps.Length; i++) // Iterate the gaps to find max to the left of current 
        {
            maxLeftSoFar[i] = Math.Max(maxLeftSoFar[i - 1], gaps[i]);
        }

        int[] maxRightSoFar = new int[n + 1];
        maxRightSoFar[n] = gaps.Last();
        for (int i = n - 1; i >= 0; i--) // Iterate the gaps to find max to the right of current
        {
            maxRightSoFar[i] = Math.Max(maxRightSoFar[i + 1], gaps[i]);
        }

        int freeTime = 0;
        for (int i = 0; i < n; i++)
        {
            int meetingDuration = endTime[i] - startTime[i];
            int sumAdjacentGaps = gaps[i] + gaps[i + 1];

            int biggestSlot = Math.Max((i == 0) ? 0 : maxLeftSoFar[i - 1], (i > n - 2) ? 0 : maxRightSoFar[i + 2]);
            if (meetingDuration <= biggestSlot) sumAdjacentGaps += meetingDuration;
            freeTime = Math.Max(freeTime, sumAdjacentGaps);
        }
        return freeTime;
    }
    static void Main(string[] args)
    {
        int evenTime1 = 10;
        int[] startTime1 = [0, 7, 9];
        int[] endTime1 = [1, 8, 10];

        int result = MaxFreeTime(evenTime1, startTime1, endTime1);
        Console.WriteLine(result);

        int evenTime2 = 10;
        int[] startTime2 = [0, 3, 7, 9];
        int[] endTime2 = [1, 4, 8, 10];
        result = MaxFreeTime(evenTime2, startTime2, endTime2);
        Console.WriteLine(result);
    }
}
