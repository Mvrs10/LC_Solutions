namespace MinimumOperationstoMakeArraySumDivisiblebyK;

internal class Program
{
    private static int MinOperations(int[] nums, int k)
    {
        int sum = 0;
        foreach (int n in nums)
        {
            sum += n;
        }

        return sum % k;
    }

    static void Main(string[] args)
    {
        int[] nums = [3, 7, 8, 10, 5, 15, 9, 9, 32, 1];
        int k = 7;

        int result = MinOperations(nums, k);
        Console.WriteLine(result);
    }
}
