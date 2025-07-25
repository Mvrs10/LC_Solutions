using System.Numerics;

namespace MaximumUniqueSubarraySumAfterDeletion;

internal class Program
{
    private static int MaxSum(int[] nums)
    {
        HashSet<int> uniques = new HashSet<int>();
        int max = int.MinValue;

        foreach (int num in nums)
        {
            if (!uniques.Contains(num) && num > 0)
                uniques.Add(num);
            max = Math.Max(max, num);
        }

        if (max < 0)
            return max;
        else
        {
            int sum = 0;
            foreach (int u in uniques)
            {
                sum += u;
            }
            return sum;
        }
    }
    static void Main(string[] args)
    {
        int[] nums = [1, 2, -1, -2, 1, 0, -1];
        int result = MaxSum(nums);
        Console.WriteLine(result);
    }
}
