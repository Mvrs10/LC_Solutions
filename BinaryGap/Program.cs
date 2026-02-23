namespace BinaryGap;

internal class Program
{
    private static int BinaryGap(int n)
    {
        int prev = -1;
        int i = 0;
        int gap = 0;

        while (n > 0)
        {
            if ((n & 1) == 1)
            {
                if (prev != -1)
                {
                    gap = Math.Max(prev, i - prev);
                }
                prev = i;
            }
            i++;
            n >>= 1;
        }

        return gap;
    }
    static void Main(string[] args)
    {
        int[] ns = [22, 8, 5];
        foreach (int n in ns)
        {
            int result = BinaryGap(n);
            Console.WriteLine(result);
        }
    }
}
