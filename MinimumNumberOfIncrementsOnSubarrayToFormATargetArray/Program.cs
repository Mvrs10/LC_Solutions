namespace MinimumNumberOfIncrementsOnSubarrayToFormATargetArray;

internal class Program
{
    private static int MinimumOperations(int[] target)
    {
        int ops = target[0];

        for (int i = 1; i < target.Length; i++)
        {
            if (target[i] > target[i - 1])
            {
                ops += target[i] - target[i - 1];
            }
        }

        return ops;
    }
    static void Main(string[] args)
    {
        int[] target = [1, 2, 3, 2, 1];
        int result = MinimumOperations(target);
        Console.WriteLine(result);
    }
}
