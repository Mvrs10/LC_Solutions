namespace PowerOfThree;

internal class Program
{
    private static bool IsPowerOfThreeRecursive(int n)
    {
        if (n == 1) return true;
        if (n <= 0 || n % 3 != 0) return false;        
        return IsPowerOfThreeRecursive(n / 3);
    }

    private static bool IsPowerOfThree(int n)
    {
        const int MAX_POWER_OF_THREE = 1162261467;
        return n > 0 && MAX_POWER_OF_THREE % n == 0;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(IsPowerOfThreeRecursive(27));
        Console.WriteLine(IsPowerOfThreeRecursive(12));
        Console.WriteLine(IsPowerOfThreeRecursive(0));
        Console.WriteLine(IsPowerOfThree(1));
        Console.WriteLine(IsPowerOfThree(243));
    }
}
