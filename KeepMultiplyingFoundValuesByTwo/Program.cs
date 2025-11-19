namespace KeepMultiplyingFoundValuesByTwo;

internal class Program
{
    private static int FindFinalValue(int[] nums, int original)
    {
        HashSet<int> set = new HashSet<int>(nums);

        while (set.Contains(original))
        {
            original *= 2;
        }

        return original;
    }

    private static int FindFinalValue_v2(int[] nums, int original)
    {
        while (nums.Contains(original))
        {
            original *= 2;
        }

        return original;
    }

    static void Main(string[] args)
    {
        int[] nums = [5, 3, 6, 1, 12];
        int result = FindFinalValue_v2(nums, 3);
        Console.WriteLine(result);
        nums = [2, 7, 9];
        result = FindFinalValue(nums, 4);
        Console.WriteLine(result);
    }
}
