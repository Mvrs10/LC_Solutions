namespace FourDivisors;

internal class Program
{
    private static int SumFourDivisors(int[] nums)
    {
        int sum = 0;

        foreach(int n in nums)
        {
            int count = 0;
            int divisor = 0;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    divisor = i;
                    count++;
                }
            }

            if (count == 1  && divisor != n / divisor)
            {
                sum += (n + 1 + divisor + n / divisor);
            }
        }

        return sum;
    }

    static void Main(string[] args)
    {
        int[] nums = [21, 4, 7];
        int result = SumFourDivisors(nums);
        Console.WriteLine(result);
    }
}
