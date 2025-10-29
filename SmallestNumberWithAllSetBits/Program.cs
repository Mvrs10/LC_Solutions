namespace SmallestNumberWithAllSetBits;

internal class Program
{
    private static int SmallestNumber(int n)
    {
        int k = 1;

        while (Math.Pow(2,k) <= n)
        {
            k++;
        }

        return (int)Math.Pow(2, k) - 1;
    }

    private static int SmallestNumber2(int n)
    {
        int i = 1;
        
        while (i <= n)
        {
            i = i * 2;
        }

        return i - 1;
    }
    static void Main(string[] args)
    {
        int[] testSets = [5, 10, 3];

        foreach (int i in testSets)
        {
            int result = SmallestNumber(i);
            Console.WriteLine(result);
            result = SmallestNumber2(i);
            Console.WriteLine(result);
        }
    }
}
