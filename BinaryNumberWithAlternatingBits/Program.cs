namespace BinaryNumberWithAlternatingBits;

internal class Program
{
    private static bool hasAlternatingBits(int n)
    {
        int lsb = n & 1;
        n >>= 1;
        
        while (n > 0)
        {
            if ((n & 1) == lsb) return false;
            lsb = n & 1;
            n >>= 1;
        }
        return true;
    }

    static void Main(string[] args)
    {
        int n = 5;
        bool result = hasAlternatingBits(n);
        Console.WriteLine(result);
    }
}
