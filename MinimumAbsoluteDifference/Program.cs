namespace MinimumAbsoluteDifference;

internal class Program
{
    private static IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        Array.Sort(arr);

        IList<IList<int>> minDiffPairs = new List<IList<int>>();
        int minDiff = 2000000;

        for (int i = 0; i < arr.Length; i++)
        {
            int diff = arr[i + 1] - arr[i];
            if (diff < minDiff)
            {
                minDiff = diff;
                minDiffPairs = new List<IList<int>>();
                minDiffPairs.Add([arr[i], arr[i + 1]]);
            }
            if (diff == minDiff)
            {
                minDiffPairs.Add([arr[i], arr[i + 1]]);
            }
        }

        return minDiffPairs;
    }
    static void Main(string[] args)
    {
        int[] arr = [1, 2, 3, 4];
        IList<IList<int>> result = MinimumAbsDifference(arr);
        foreach(IList<int> r in result)
        {
            Console.WriteLine($"{r[0]} - {r[1]}");
        }
    }
}
