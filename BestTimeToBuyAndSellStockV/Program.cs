namespace BestTimeToBuyAndSellStockV;

internal class Program
{
    private static long MaximumProfit(int[] prices, int k)
    {
        int n = prices.Length;
        if (n == 0) return 0;

        long[] dpPrev = new long[(k + 1) * 3];
        long[] dpCurr = new long[(k + 1) * 3];

        for (int j = 0; j <= k; j++)
        {
            dpPrev[j * 3 + 0] = 0;
            dpPrev[j * 3 + 1] = long.MinValue / 2;
            dpPrev[j * 3 + 2] = long.MinValue / 2;
        }

        for (int priceIdx = 0; priceIdx < n; priceIdx++)
        {
            int price = prices[priceIdx];

            dpCurr[0 * 3 + 0] = dpPrev[0 * 3 + 0];
            dpCurr[0 * 3 + 1] = dpPrev[0 * 3 + 1];
            dpCurr[0 * 3 + 2] = dpPrev[0 * 3 + 2];

            for (int j = 1; j <= k; j++)
            {
                int baseIndex = j * 3;
                int prevIndex = baseIndex;
                int prevJIndex = (j - 1) * 3;

                dpCurr[baseIndex + 0] = Math.Max(
                    dpPrev[prevIndex + 0],
                    Math.Max(
                        dpPrev[prevIndex + 1] + price,
                        dpPrev[prevIndex + 2] - price
                    )
                );

                dpCurr[baseIndex + 1] = Math.Max(
                    dpPrev[prevIndex + 1],
                    dpPrev[prevJIndex + 0] - price
                );

                dpCurr[baseIndex + 2] = Math.Max(
                    dpPrev[prevIndex + 2],
                    dpPrev[prevJIndex + 0] + price
                );
            }

            var temp = dpPrev;
            dpPrev = dpCurr;
            dpCurr = temp;
        }

        return dpPrev[k * 3 + 0];
    }

    static void Main(string[] args)
    {
        int[] prices = [1, 7, 9, 8, 2];
        int k = 2;
        long result = MaximumProfit(prices, k);
        Console.WriteLine(result);
    }
}
