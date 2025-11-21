using System.Numerics;

namespace ThirdMaximumNumber;

internal class Program
{
    private static int ThirdMax(int[] nums)
    {
        Array.Sort(nums, (a, b) => b.CompareTo(a));
        int thirdMax = nums[0];
        int count = 0;
        int n = nums.Length;

        for (int i = 1; i < n; i++)
        {
            if (nums[i - 1] == nums[i])
                continue;
            count++;

            if (count == 2)
            {
                thirdMax = nums[i];
                break;
            }
        }

        return thirdMax;
    }

    private static int ThirdMax_v2(int[] nums)
    {
        long first = long.MinValue;
        long second = long.MinValue;
        long third = long.MinValue;
        int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            if (nums[i] == first || nums[i] == second || nums[i] == third)
                continue;

            if (nums[i] > first)
            {
                third = second;
                second = first;
                first = nums[i];
            }
            else if (nums[i] > second)
            {
                third = second;
                second = nums[i];
            }
            else if (nums[i] > third)
            {
                third = nums[i];
            }
        }

        return (int)((third != long.MinValue) ? third : first);
    }
    static void Main(string[] args)
    {
        int[] nums = [1, 2, 2, 3, 4, 4, 4, 5, 5, 9, 9, 9, 9, -2];
        int result = ThirdMax(nums);
        Console.WriteLine(result);

        nums = [3,2,1];
        result = ThirdMax(nums);
        Console.WriteLine(result);

        nums = [-2147483648, 1, 2];
        result = ThirdMax(nums);
        Console.WriteLine(result);

        result = ThirdMax_v2(nums);
        Console.WriteLine(result);
    }
}
