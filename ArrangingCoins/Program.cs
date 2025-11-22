namespace ArrangingCoins;

internal class Program
{
    private static int ArrangeCoins(int n)
    {
        int row = 0;
        int i = 1;

        while (n > 0)
        {
            n -= i;
            i++;
            row++;
        }

        return (n == 0) ? row : row - 1;
    }

    private static int ArrangeCoins_v2(int n)
    {
        return (int)(-1 + Math.Sqrt(1 + 8.0*n)) / 2;
    }

    static void Main(string[] args)
    {
        int result = ArrangeCoins(6);
        Console.WriteLine(result);
        result = ArrangeCoins(5);
        Console.WriteLine(result);
        result = ArrangeCoins_v2(6);
        Console.WriteLine(result);
        result = ArrangeCoins_v2(5);
        Console.WriteLine(result);
    }
}
