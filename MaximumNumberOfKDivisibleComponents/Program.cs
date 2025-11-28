namespace MaximumNumberOfKDivisibleComponents;

internal class Solution
{
    private long[]? clones = null;
    private List<int>[]? adj = null;
    private int K;
    private int count;

    public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k)
    {
        K = k;
        count = 0;
        adj = new List<int>[n];
        clones = new long[n];
        for (int i = 0; i < n; i++)
        {
            adj[i] = new List<int>();
            clones[i] = values[i];
        }        

        long DFS(int u, int parent)
        {
            long sum = clones![u];
            foreach(int v in adj![u])
            {
                if (v == parent) continue;
                sum += DFS(v, u);
            }

            if (sum % K == 0)
            {
                count++;
                return 0;
            }

            return sum;
        }


        foreach (int[] e in edges)
        {
            int r = e[0], l = e[1];
            adj[r].Add(l);
            adj[l].Add(r);
        }

        DFS(0, -1);

        return count;
    }
    static void Main(string[] args)
    {
        int n = 5, k = 6;
        int[][] edges = [[0, 2], [1, 2], [1, 3], [2, 4]];
        int[] values = [1, 8, 1, 4, 4];
        Solution sol = new Solution();
        int result = sol.MaxKDivisibleComponents(n, edges, values, k);
        Console.WriteLine(result);
    }
}
