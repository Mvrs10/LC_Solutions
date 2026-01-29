namespace MinimumCostToConvertString1;

internal class Program
{
    private static long MinimumCost(string source, string target, char[] original, char[] changed, int[] cost)
    {
        long MAX = 26 * 1000000;
        long[,] graph = new long[26, 26];

        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < 26; j++)
                graph[i, j] = i == j ? 0 : MAX;
        }

        for (int i = 0; i < original.Length; i++)
        {
            int u = original[i] - 'a';
            int v = changed[i] - 'a';
            graph[u, v] = Math.Min(graph[u, v], cost[i]);
        }

        for (int k = 0; k < 26; k++)
        {
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (graph[i, k] + graph[k, j] < graph[i, j])
                        graph[i, j] = graph[i, k] + graph[k, j];
                }
            }
        }

        long totalCost = 0;
        for (int i = 0; i < source.Length; i++)
        {
            int s = source[i] - 'a';
            int t = target[i] - 'a';

            if (graph[s, t] == MAX)
                return -1;

            totalCost += graph[s, t];
        }

        return totalCost;
    }

    static void Main(string[] args)
    {
        string source = "aaaa", target = "bbbb";
        char[] original = ['a', 'c'], changed = ['c', 'b'];
        int[] cost = [1, 2];

        long result = MinimumCost(source, target, original, changed, cost);
        Console.WriteLine(result);
    }
}
