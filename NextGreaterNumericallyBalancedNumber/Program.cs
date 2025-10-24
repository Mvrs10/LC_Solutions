namespace NextGreaterNumericallyBalancedNumber;

internal class Program
{
    private static int NextBeautifulNumber (int n)
    {
        const int MAX_BEAUTIFUL = 1224444;

        static bool IsBeautiful (int x)
        {
            int[] freq = new int[10];

            while (x > 0)
            {
                int digit = x % 10;
                freq[digit]++;
                x /= 10;
            }

            for (int i = 0; i < 10; i++)
            {
                if (freq[i] != 0 && freq[i] != i)
                    return false;
            }
            return true;
        }

        for (int i = n + 1; i <= MAX_BEAUTIFUL; i++)
        {
            if (IsBeautiful(i))
                return i;
        }

        return MAX_BEAUTIFUL;
    }
    static void Main(string[] args)
    {
        int n = 9;
        int result = NextBeautifulNumber(n);
        Console.WriteLine(result);
    }
}
