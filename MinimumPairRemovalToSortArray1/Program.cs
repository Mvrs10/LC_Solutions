namespace MinimumPairRemovalToSortArray1;

internal class Program
{
    private static int MinimumPairRemoval(int[] nums)
    {
        int ops = 0;
        List<int> nums2 = new List<int>(nums);

        while (!IsNonDecreasing(nums2))
        {
            RemoveMinPair(nums2);
            ops++;
        }

        return ops;
    }

    private static bool IsNonDecreasing(List<int> nums)
    {
        for (int i = 0; i < nums.Count - 1; i++)
        {
            if (nums[i] > nums[i + 1]) return false;

        }

        return true;
    }

    private static void RemoveMinPair(List<int> nums)
    {
        int j = 0;
        int sum = nums.Count * 1000;

        for (int i = 0; i < nums.Count - 1; i++)
        {
            if (nums[i] + nums[i + 1] < sum)
            {
                j = i;
                sum = nums[i] + nums[i + 1];
            }
        }

        nums[j] = sum;
        nums.RemoveAt(j + 1);
    }

    static void Main(string[] args)
    {
        int[] nums1 = [689, -360, 234, 673, 663, -741, 480, 860, -707, 209, 246, 792, 930, 696, -305];
        int result = MinimumPairRemoval(nums1);
        Console.WriteLine(result);
    }
}
