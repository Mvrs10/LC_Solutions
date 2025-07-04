using System.Text;

namespace FindTheKthCharacterInStringGame2;

internal class Program
{
    private static char KthCharacter(long k, int[] operations)
    {
        long n = 1;
        int i = 0;

        while (n < k) // Find the exponent to reach k in the second half.
        {
            n *= 2;
            i++;
        }

        int shiftCount = 0;
        while (n > 1) // Reverse
        {
            if (k > n / 2)
            {
                k -= n / 2; // New k-th position in the second half.
                shiftCount += operations[i - 1]; // 0 no shift - 1 shift by a character
            }
            n /= 2;
            i--;
        }
        return (char)('a' + (shiftCount % 26));
    }
    private static char KthCharacter_v2(long k, int[] operations)
    {
        int shiftCount = 0;
        long n = 1;
        int exponent = 0; // number of operations

        while (n < k) // Find the smallest n length and number of operations to reach k.
        {
            n *= 2;
            exponent++;
        }
        for (int i = exponent - 1; i >= 0; i--) // Reverse the operation because the string grows exponentially(double). K is unaffected if it's in the first half of the current string.
        {
            long halfLength = n / 2; // Zoom-in the first half aka search in first half reversly to locate k. Continue until k is in first half.
            switch (operations[i])
            {
                case 0:
                    if (halfLength < k) k -= halfLength; // Trim the first half to find new k-th position in the second half
                    break;
                case 1:                    
                    if (halfLength < k)
                    {
                        k -= halfLength; // Trim the first half to find new k-th position in the second half
                        shiftCount++; // position contains the next of previous char
                    }
                    break;
            }
            n /= 2;
        }
        return (char)('a' + (shiftCount%26));
    }
    static void Main(string[] args)
    {
        int[] operations = [0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0];
        long k = 33354182522397;
        Console.WriteLine(KthCharacter(k, operations));
        Console.WriteLine(KthCharacter_v2(k, operations));
    }
}
