namespace CountNumberOfTrapezoids1;

internal class Program
{
    private static int CountTrapezoids(int[][] points)
    {
        const int MOD = 1_000_000_007;
        Dictionary<int,int> groupByYaxis = new Dictionary<int,int>();
        foreach (int[] point in points)
        {
            if (!groupByYaxis.ContainsKey(point[1]))
            {
                groupByYaxis[point[1]] = 0;
            }
            groupByYaxis[point[1]]++;
        }

        long trapezoids = 0;

        foreach (KeyValuePair<int,int> curKV in groupByYaxis)
        {
            long currGroupSegments = curKV.Value * (curKV.Value - 1) / 2;
            groupByYaxis.Remove(curKV.Key);
            foreach (KeyValuePair<int,int> nextKV in groupByYaxis)
            {
                long nextGroupSegments = nextKV.Value * (nextKV.Value - 1) / 2;
                trapezoids += currGroupSegments * nextGroupSegments;
            }
        }

        return (int)trapezoids % MOD;
    }

    private static int CountTrapezoids_v2(int[][] points)
    {
        const int MOD = 1_000_000_007;
        Dictionary<int, int> groupByYaxis = new Dictionary<int, int>();
        foreach (int[] point in points)
        {
            if (!groupByYaxis.ContainsKey(point[1]))
            {
                groupByYaxis[point[1]] = 0;
            }
            groupByYaxis[point[1]]++;
        }

        long trapezoids = 0;
        long prefixSum = 0;

        foreach (KeyValuePair<int, int> kv in groupByYaxis)
        {
            long point = kv.Value;
            if (point == 1) continue;

            long segments = point * (point - 1) / 2;
            trapezoids += segments * prefixSum;
            prefixSum += segments;
        }

        return (int)(trapezoids % MOD);
    }

    static void Main(string[] args)
    {
        int[][] points = [[1, 0], [2, 0], [3, 0], [2, 2], [3, 2]];
        int result = CountTrapezoids(points);
        Console.WriteLine(result);
        result = CountTrapezoids_v2(points);
        Console.WriteLine(result);
    }
}
