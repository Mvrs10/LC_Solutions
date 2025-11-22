namespace FindMinimumOperationsToMakeAllElementsDivisibleByThree;

internal class Program
{
    private static int MinimumOperations(int[] nums)
    {
        int count = 0;

        foreach (int n in nums)
        {
            if (n % 3 != 0)
                count++;
        }

        return count;
    }
    static void Main(string[] args)
    {
        int[] nums = [1, 2, 3, 4];
        int result = MinimumOperations(nums);
        Console.WriteLine(result);
    }
}
