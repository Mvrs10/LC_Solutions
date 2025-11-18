namespace _1_bitAnd2_bitCharacters;

internal class Program
{
    private static bool IsOneBitCharacter(int[] bits)
    {
        bool isOneBit = true;
        int i = 0;
        while (i < bits.Length)
        {
            if (bits[i] == 0)
            {
                isOneBit = true;
                i++;
            }
            else
            {
                isOneBit = false;
                i += 2;
            }
        }

        return isOneBit;
    }
    static void Main(string[] args)
    {
        int[] bits = [1,1,1,0];
        bool result = IsOneBitCharacter(bits);
        Console.WriteLine(result);
    }
}
