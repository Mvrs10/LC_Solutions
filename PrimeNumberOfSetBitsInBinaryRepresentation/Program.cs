namespace PrimeNumberOfSetBitsInBinaryRepresentation;

internal class Program
{
    private static int CountPrimeSetBits(int left, int right)
    {
        int CountSetBits(int n)
        {
            int count = 0;

            while (n > 0)
            {
                if ((n & 1) == 1) count++;
                n >>= 1;
            }

            return count;
        }

        bool isPrime(int n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;

            for (int i = 5; i * i < n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0) return false;
            }

            return true;
        }

        int prime = 0;
        for (int i = left; i <= right; i++)
        {
            int setBits = CountSetBits(i);
            if (isPrime(setBits)) prime++;
        }

        return prime;
    }

    static void Main(string[] args)
    {
        int left = 6, right = 10;
        int result = CountPrimeSetBits(left, right);
        Console.WriteLine(result);
    }
}
