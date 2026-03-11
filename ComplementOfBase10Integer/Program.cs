namespace ComplementOfBase10Integer;

internal class Program
{
    private static int BitwiseComplement(int n)
    {
        if (n == 0) return 1;
        int complement = 0;
        int bitIdx = 0;

        while (n > 0)
        {
            int lsb = (n & 1);
            int flip = lsb == 0 ? 1 : 0;
            flip <<= bitIdx++;
            complement |= flip;            
            n >>= 1;
        }

        return complement;
    }
    static void Main(string[] args)
    {
        int n = 10;
        int result = BitwiseComplement(n);
        Console.WriteLine(result);
    }
}
