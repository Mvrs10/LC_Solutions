namespace MinimumOneBitOperationsToMakeIntegersZero;

internal class Program
{
    private static int minimumOneBitOperations(int n)
    {
        int result = 0;
        while (n > 0)
        {
            result ^= n;
            n >>= 1;
        }
        return result;
    }
    static void Main(string[] args)
    {
        int result = minimumOneBitOperations(15);
        Console.WriteLine(result);
    }
}
