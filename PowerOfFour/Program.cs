namespace PowerOfFour;

internal class Program
{
    private static bool IsPowerOfFour(int n)
    {
        return n > 0 && (n & (n - 1)) == 0 && (n & 0x55555555) != 0;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(IsPowerOfFour(16));
        Console.WriteLine(IsPowerOfFour(1));
        Console.WriteLine(IsPowerOfFour(132));
    }
}
