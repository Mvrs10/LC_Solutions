namespace MaximumNumberOfEventsThatCanBeAttended;

internal class Program
{
    private static int MaxEvents(int[][] events)
    {
        Array.Sort(events, (current, next) => current[0] == next[0] ? current[1] - next[1] : current[0] - next[0]);

        PriorityQueue<int[],int> schedule = new PriorityQueue<int[],int>(); // Implement a min-heap
        int day = 1, count = 0;
        int i = 0, n = events.Length;
        while (i < n || schedule.Count > 0)
        {
            while (i < n && events[i][0] == day) // Add events starting on day i to schedule
            {
                schedule.Enqueue(events[i], events[i][1]); // Element: event - Priority: last day
                i++;
            }

            while (schedule.Count > 0 && schedule.Peek()[1] < day) // Remove expired events
            {
                schedule.Dequeue();
            }
            
            if (schedule.Count > 0) // Attend ONE event
            {
                count++;
                schedule.Dequeue();
            }
            day++;
        }
        return count;
    }
    static void Main(string[] args)
    {
        int[][] events1 = [[1, 2], [2, 3], [3, 4]];
        int result = MaxEvents(events1);
        Console.WriteLine(result);
        int[][] events2 = [[1, 2], [2, 3], [3, 4], [1, 2], [1, 2], [1, 2]];
        result = MaxEvents(events2);
        Console.WriteLine(result);
        int[][] events3 = [[1, 2], [1, 2], [1, 2], [1, 2], [1, 2]];
        result = MaxEvents(events3);
        Console.WriteLine(result);
        int[][] events4 = [[3, 4]];
        result = MaxEvents(events4);
        Console.WriteLine(result);
        int[][] events5 = [[1, 2], [2, 2], [2, 2], [2, 2], [2, 2]];
        result = MaxEvents(events5);
        Console.WriteLine(result);
    }
}
