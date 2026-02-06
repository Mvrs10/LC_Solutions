using System.Runtime.CompilerServices;

namespace MinimumRemovalsToBalanceArray;

internal class Program
{
    private static int MinRemoval(int[] nums, int k)
    {
        int min = nums.Length;
        Array.Sort(nums);

        for (int i = 0, j = 0; j < nums.Length; j++)
        {
            while (i < j && (long)nums[i] * k < nums[j])
            {
                i++;
            }

            min = Math.Min(min, nums.Length - (j - i + 1));
        }

        return min;
    }

    static void Main(string[] args)
    {
        int k = 3;
        int[] nums = [1, 6, 2, 9];

        int result = MinRemoval(nums, k);
        Console.WriteLine(result);
    }
}
