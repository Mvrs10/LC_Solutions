namespace NumberOfSmoothDescentPeriodOfAStock;

internal class Program
{
    private static long GetDescentPeriods(int[] prices)
    {
        int left = 0;
        int right = 0;
        long k = 0;
        long descentPeriods = 0;

        while (right < prices.Length)
        {
            while (right < prices.Length && (left == right || prices[right - 1] - prices[right] == 1))
            {
                k++;
                right++;
            }

            left = right;
            descentPeriods += k * (k + 1) / 2;
            k = 0;
        }

        return descentPeriods;
    }
    static void Main(string[] args)
    {
        int[][] testCases = [[3, 2, 1, 4], [8, 6, 7, 7], [1]];
        foreach (int[] prices in testCases)
        {
            long result = GetDescentPeriods(prices);
            Console.WriteLine(result);
        }
    }
}
