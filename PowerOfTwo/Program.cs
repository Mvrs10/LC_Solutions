namespace PowerOfTwo;

internal class Program
{
    private static bool IsPowerOfTwo(int n)
    {
        double logVal = Math.Log(n, 2);
        return Math.Abs(logVal - Math.Round(logVal)) < 1e-12;
    }

    private static bool IsPowerOfTwoV2(int n)
    {
        if (n <= 0) return false;
        while (n > 1)
        {
            if (n % 2 != 0) return false;
            n /= 2;
        }
        return true;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(IsPowerOfTwo(2147483647));
        Console.WriteLine(IsPowerOfTwo(536870912));
        Console.WriteLine(IsPowerOfTwoV2(2147483647));
        Console.WriteLine(IsPowerOfTwoV2(536870912));
    }
}
