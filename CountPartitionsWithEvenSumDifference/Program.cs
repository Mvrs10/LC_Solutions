namespace CountPartitionsWithEvenSumDifference;

internal class Program
{
    private static int CountPartitions(int[] nums)
    {
        int[] prefix = new int[nums.Length];
        prefix[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            prefix[i] = prefix[i - 1] + nums[i];
        }

        int partitions = 0;
        int total = prefix.Last();
        for (int i = 0; i < prefix.Length - 1; i++)
        {
            if ((total - 2 * prefix[i]) % 2 == 0)
                partitions++;
        }

        return partitions;
    }

    private static int CountPartitions_v2(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }

        if (nums[nums.Length - 1] % 2 == 0) return nums.Length - 1;
        return 0;
    }
    static void Main(string[] args)
    {
        int[] nums = [1,1];
        int result = CountPartitions(nums);
        Console.WriteLine(result);
        nums = [10, 10, 1, 2, 3];
        result = CountPartitions_v2(nums);
        Console.WriteLine(result);
    }
}
