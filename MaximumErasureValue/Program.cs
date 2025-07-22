namespace MaximumErasureValue;

internal class Program
{
    private static int MaximumUniqueSubarray(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();
        int left = 0;
        int sum = 0;
        int result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            while (seen.Contains(nums[i]))
            {
                seen.Remove(nums[left]);
                sum -= nums[left];
                left++;
            }
            seen.Add(nums[i]);
            sum += nums[i];
            result = Math.Max(sum, result);
        }

        return result;
    }
    static void Main(string[] args)
    {
        int[] nums = [187, 470, 25, 436, 538, 809, 441, 167, 477, 110, 275, 133, 666, 345, 411, 459, 490, 266, 987, 965, 429, 166, 809, 340, 467, 318, 125, 165, 809, 610, 31, 585, 970, 306, 42, 189, 169, 743, 78, 810, 70, 382, 367, 490, 787, 670, 476, 278, 775, 673, 299, 19, 893, 817, 971, 458, 409, 886, 434];
        int result = MaximumUniqueSubarray(nums);
        Console.WriteLine(result);
    }
}
