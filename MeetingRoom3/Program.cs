namespace MeetingRoom3;

internal class Program
{
    private static int MostBooked(int n, int[][] meetings)
    {
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));

        var available = new PriorityQueue<int, int>();
        for (int i = 0; i < n; i++)
            available.Enqueue(i, i);

        var busy = new PriorityQueue<(long end, int room), (long, int)>();

        int[] usage = new int[n];

        foreach (var meeting in meetings)
        {
            long start = meeting[0];
            long end = meeting[1];
            long duration = end - start;

            while (busy.Count > 0 && busy.Peek().end <= start)
            {
                var (_, room) = busy.Dequeue();
                available.Enqueue(room, room);
            }

            if (available.Count > 0)
            {
                int room = available.Dequeue();
                busy.Enqueue((end, room), (end, room));
                usage[room]++;
            }
            else
            {
                var (freeTime, room) = busy.Dequeue();
                long newEnd = freeTime + duration;
                busy.Enqueue((newEnd, room), (newEnd, room));
                usage[room]++;
            }
        }

        int result = 0;
        for (int i = 1; i < n; i++)
        {
            if (usage[i] > usage[result])
                result = i;
        }

        return result;
    }

    static void Main(string[] args)
    {
        int n = 2;
        int[][] meetings = [[0, 10], [1, 5], [2, 7], [3, 4]];

        int result = MostBooked(n, meetings);
        Console.WriteLine(result);
    }
}
