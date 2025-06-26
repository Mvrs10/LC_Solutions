namespace ReverseBits;

internal class Program
{
    private static uint ReverseBitsMovingN(uint n)
    {
        uint result = 0;
        for (int i = 31; i >=0; i--)
        {
            uint bit = (n >> 31 -i) & 1;
            result |= bit << i;
        }
        return result;
    }
    private static uint ReverseBitsMovingResult(uint n)
    {
        uint result = 0;
        for (int i = 0; i < 32; i++)
        {
            result <<= 1;
            result |= (n & 1);
            n >>= 1;
        }
        return result;
    }
    static void Main(string[] args)
    {
        uint n = 0b00000010100101000001111010011100;
        uint b = 0b11111111111111111111111111111101;
        uint result = ReverseBitsMovingN(n);
        Console.WriteLine(result);
        result = ReverseBitsMovingResult(b);
        Console.WriteLine(result);
    }
}
