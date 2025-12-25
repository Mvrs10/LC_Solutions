namespace MaximizeHappinessOfSelectedChildren;

internal class Program
{
    private static long MaximumHappinessSum(int[] happiness, int k)
    {
        Array.Sort(happiness, (a, b) => (b.CompareTo(a)));

        long max = 0;

        for (int i = 0; i < k; i++)
        {
            long currentValue = happiness[i] - i;
            max += currentValue >= 0 ? currentValue : 0;
        }

        return max;
    }

    static void Main(string[] args)
    {
        int[] happiness = [1, 2, 3];
        int k = 3;
        long result = MaximumHappinessSum(happiness, k);
        Console.WriteLine(result);
    }
}
