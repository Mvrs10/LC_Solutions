namespace CountCoveredBuildings;

internal class Program
{
    private static int CountCoveredBuildings(int n, int[][] buildings)
    {
        Dictionary<int, SortedSet<int>> rowGroups = new Dictionary<int, SortedSet<int>>(n);
        Dictionary<int, SortedSet<int>> colGroups = new Dictionary<int, SortedSet<int>>(n);

        foreach (int[] building in buildings)
        {
            if (!rowGroups.ContainsKey(building[0]))
                rowGroups[building[0]] = new SortedSet<int>();
            rowGroups[building[0]].Add(building[1]);

            if (!colGroups.ContainsKey(building[1]))
                colGroups[building[1]] = new SortedSet<int>();
            colGroups[building[1]].Add(building[0]);
        }

        int coveredBuildings = 0;

        foreach (int[] building in buildings)
        {
            bool isCoveredHorizontally = building[1] > rowGroups[building[0]].Min && building[1] < rowGroups[building[0]].Max;
            bool isCoveredVertically = building[0] > colGroups[building[1]].Min && building[0] < colGroups[building[1]].Max;

            if (isCoveredHorizontally && isCoveredVertically)
                coveredBuildings++;
        }

        return coveredBuildings;
    }
    static void Main(string[] args)
    {
        int[][] buildings = [[1, 2], [2, 2], [3, 2], [2, 1], [2, 3]];
        int n = 3;
        int result = CountCoveredBuildings(n, buildings);
        Console.WriteLine(result);
    }
}
