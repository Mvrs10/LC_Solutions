namespace CountSquareSumTriples;

internal class Program
{
    private static int CountTriples(int n)
    {
        int triples = 0;

        for (int a = 1; a < n; a++)
        {
            for (int b = a + 1; b < n; b++)
            {
                int c = a * a + b * b;
                double cRooted = Math.Sqrt(c);
                if ((cRooted - (int)cRooted) == 0 && cRooted <= n)
                    triples += 2;
            }
        }

        return triples;
    }

    private static int CountTriples_v2(int n)
    {
        int count = 0;

        for (int c = 1; c <= n; ++c)
        {
            int target = c * c;
            int left = 1;
            int right = c - 1;

            while (left < right)
            {
                int sum = left * left + right * right;

                if (sum == target)
                {
                    count += 2;
                    left++;
                    right--;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        int[] testCases = [5, 10, 1, 250];

        foreach (int n in testCases)
        {
            Console.WriteLine(CountTriples(n) + Environment.NewLine + CountTriples_v2(n));
        }
    }
}
