namespace CountOddNumbersInAnIntervalRange;

internal class Program
{
    private static int CountOdds(int low, int high)
    {
        int oddCount = 0;
        if ((low % 2) != 0)
        {
            oddCount++;
            low++;
        }
        if ((high % 2) != 0)
        {
            oddCount++;
            high--;
        }

        oddCount += ((high - low) / 2);
        return oddCount;
    }
    static void Main(string[] args)
    {
        int[][] testCases = [[3, 7], [8, 10], [1, 2], [9, 9], [10, 10]];
        foreach (int[] test in testCases)
        {
            int result = CountOdds(test[0], test[1]);
            Console.WriteLine(result);
        }
    }
}
