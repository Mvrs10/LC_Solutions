namespace NumberOfWaysToPaintNx3Grid;

internal class Program
{
    private static int NumberOfWays(int n)
    {
        int MOD = 1_000_000_007;
        long twoColor = 6;
        long threeColor = 6;

        for (int i = 2; i <= n; i++)
        {
            long newTwo = (3 * twoColor + 2 * threeColor) % MOD;
            long newThree = (2 * twoColor + 2 * threeColor) % MOD;

            twoColor = newTwo;
            threeColor = newThree;
        }

        return (int)((twoColor + threeColor) % MOD);
    }

    static void Main(string[] args)
    {
        int n = 2;
        int result = NumberOfWays(n);
        Console.WriteLine(result);
    }
}
