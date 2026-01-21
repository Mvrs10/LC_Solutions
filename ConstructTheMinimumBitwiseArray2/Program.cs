namespace ConstructTheMinimumBitwiseArray2;

internal class Program
{
    private static int[] MinBitwiseArray(IList<int> nums)
    {
        for (int i = 0; i < nums.Count; i++)
        {
            int x = -1;
            int d = 1;
            while ((nums[i] & d) != 0)
            {
                x = nums[i] - d;
                d <<= 1;
            }
            nums[i] = x;
        }

        return nums.ToArray();
    }
    static void Main(string[] args)
    {
        IList<int> nums = [2, 3, 5, 7];
        int[] result = MinBitwiseArray(nums);
        foreach (int n in result)
        {
            Console.Write(n + " ");
        }
    }
}
