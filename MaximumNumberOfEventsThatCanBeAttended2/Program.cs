namespace MaximumNumberOfEventsThatCanBeAttended2;

internal class Program
{
    //Helper function - Search rightmost compatible index endDay < startDay
    private static int BinarySearch(int[] endDays, int startDay, int endIndex)
    {
        int left = 0, right = endIndex - 1;
        int result = -1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (startDay > endDays[mid])
            {
                result = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return result;
    }
    private static int MaxValue(int[][] events, int k)
    {
        int n = events.Length;
        //1. Sort events by start and end time.
        Array.Sort(events, (cur, next) => cur[1].CompareTo(next[1]));
        
        //2. Create DP multi-dimension array of size (nxk+1)
        // dp[i][j] = first i events with j selections, e.g i=5,k=3, first 5 events with 3 attended events
        int[,] dp = new int[n + 1, k + 1];

        //3. Create an array of event end days for binary search selection
        int[] endDays = new int[n];
        for (int i = 0; i < n; i++) endDays[i] = events[i][1];

        //4. Core logic
        for (int i = 1; i <=n; i++)
        {
            int startDay = events[i - 1][0];
            int value = events[i - 1][2];

            // Search event with highest endDay right before the current startDay
            int prevEvent = BinarySearch(endDays, startDay, i - 1);

            // Loop thru the selection to pick the highest value with events[i]
            for(int j = 1; j <= k; j++)
            {
                dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j]); // We skip the current event

                dp[i, j] = Math.Max(dp[i, j], dp[prevEvent + 1, j - 1] + value); // We take the current event + best of compatible previous

            }
        }

        //5. Result is the best we can do using all events and up to k selections
        return dp[n, k];
    }
    static void Main(string[] args)
    {
        
    }
}
