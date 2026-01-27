namespace MinimumCostPathWithEdgeReversals;

internal class Program
{
    private static int MinCost(int n, int[][] edges)
    {
        List<(int To, int Cost)>[] adj = new List<(int, int)>[n];
        for (int i = 0; i < n; i++) adj[i] = new List<(int, int)>();

        foreach (int[] edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            int w = edge[2];
            adj[u].Add((v, w));
            adj[v].Add((u, 2 * w));
        }

        int[] dist = new int[n];
        Array.Fill(dist, int.MaxValue);
        dist[0] = 0;

        LinkedList<int> deque = new LinkedList<int>();
        deque.AddFirst(0);

        while (deque.Count > 0)
        {
            int curr = deque.First.Value;
            deque.RemoveFirst();

            foreach (var (neighbor, weight) in adj[curr])
            {
                if (dist[curr] + weight < dist[neighbor])
                {
                    dist[neighbor] = dist[curr] + weight;

                    if (weight == 0)
                    {
                        deque.AddFirst(neighbor);
                    }
                    else
                    {
                        deque.AddLast(neighbor);
                    }
                }
            }
        }

        return dist[n - 1] == int.MaxValue ? -1 : dist[n - 1];
    }
    static void Main(string[] args)
    {
        int n = 4;
        int[][] edges = [[0, 1, 3], [3, 1, 1], [2, 3, 4], [0, 2, 2]];

        int result = MinCost(n, edges);
        Console.WriteLine(result);
    }
}
