namespace DeleteColumnsToMakeSorted2;

internal class Program
{
    private static int MinDeletionSize(string[] strs)
    {
            int n = strs.Length;
            int m = strs[0].Length;

            bool[] sorted = new bool[n - 1];
            int deletions = 0;

            for (int col = 0; col < m; col++)
            {
                bool isDeleted = false;

                for (int i = 0; i < n - 1; i++)
                {
                    if (!sorted[i] && strs[i][col] > strs[i+1][col])
                    {
                        isDeleted = true;
                        break;
                    }
                }

                if (isDeleted)
                {
                    deletions++;
                    continue;
                }

                for (int i = 0; i < n - 1; i++)
                {
                    if (!sorted[i] && strs[i][col] < strs[i + 1][col])
                    {
                        sorted[i] = true;
                    }
                }
            }

            return deletions;
    }

    static void Main(string[] args)
    {
        string[] strs = ["xc", "yb", "za"];
        int result = MinDeletionSize(strs);
        Console.WriteLine(result);
    }
}
