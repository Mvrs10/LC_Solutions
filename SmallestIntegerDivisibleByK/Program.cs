namespace SmallestIntegerDivisibleByK;

internal class Program
{
    private static int SmallestRepunitDivByK(int k)
    {
        if (k % 2 == 0 || k % 5 == 0)
            return -1;

        int remainder = 0;
        for (int i = 1; i <= k; i++)
        {
            remainder = (remainder * 10 + 1) % k;
            if (remainder == 0)
                return i;
        }
        return -1;
    }

    static void Main(string[] args)
    {
        int K = 3;
        int result = SmallestRepunitDivByK(K);
        Console.WriteLine(result);
    }
}
