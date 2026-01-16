namespace MaximumSquareAreaByRemovingFencesFromAField;

internal class Program
{
    private static int MaximizeSquareArea(int m, int n, int[] hFences, int[] vFences)
    {
        int h = hFences.Length, v = vFences.Length;
        long side = 0, MOD = 1_000_000_007;

        Array.Resize(ref hFences, h + 2);
        hFences[h] = 1;
        hFences[h + 1] = m;

        Array.Resize(ref vFences, v + 2);
        vFences[v] = 1;
        vFences[v + 1] = n;

        HashSet<int> seen = new HashSet<int>();
        for (int i = 0; i < h + 1; i++)
        {
            for (int j = i + 1; j < h + 2; j++)
            {
                seen.Add(Math.Abs(hFences[j] - hFences[i]));
            }
        }

        for (int i = 0; i < v + 1; i++)
        {
            for (int j = i + 1; j < v + 2; j++)
            {
                int l = Math.Abs(vFences[j] - vFences[i]);
                if (seen.Contains(l))
                {
                    side = Math.Max(side, l);
                }
            }
        }
 
        return side == 0 ? -1 : (int)(side * side % MOD);
    }

    static void Main(string[] args)
    {
        int m = 6;
        int n = 7;
        int[] hFences = [2];
        int[] vFences = [4];

        int result = MaximizeSquareArea(m,n,hFences,vFences);
        Console.WriteLine(result);
    }
}
