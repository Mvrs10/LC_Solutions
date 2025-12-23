namespace TwoBestNonOverlappingEvents;

internal class Program
{
    private static int MaxTwoEvents(int[][] events)
    {
        Array.Sort(events, (a,b) => a[0].CompareTo(b[0]));

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

        int maxEndValue = 0;
        int maxTotalValues = 0;

        foreach (int[] e in events)
        {
            int start = e[0];
            int end = e[1];
            int value = e[2];

            pq.TryPeek(out int prevValue, out int prevEnd);

            while (pq.Count > 0 && prevEnd < start)
            {
                int current = pq.Dequeue();
                maxEndValue = Math.Max(current, maxEndValue);
                pq.TryPeek(out int nextValue, out int nextEnd);
                prevEnd = nextEnd;
            }

            maxTotalValues = Math.Max(maxTotalValues, maxEndValue + value);

            pq.Enqueue(value, end);
        }

        return maxTotalValues;
    }
    static void Main(string[] args)
    {
        int[][] events = [[1, 3, 2], [4, 5, 2], [2, 4, 3]];
        int result = MaxTwoEvents(events);
        Console.WriteLine(result);
    }
}
