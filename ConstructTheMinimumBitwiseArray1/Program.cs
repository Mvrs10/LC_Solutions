namespace ConstructTheMinimumBitwiseArray1;

internal class Program
{
    private static int[] MinBitwiseArray(IList<int> nums)
    {
        int[] ans = new int[nums.Count];

        for (int i = 0; i < nums.Count; i++)
        {
            ans[i] = -1;
            for (int j = 0; j < 1001; j++)
            {
                if ((j | (j + 1)) == nums[i])
                {
                    ans[i] = j;
                    break;
                }
            }
        }

        return ans;
    }
    static void Main(string[] args)
    {
        IList<int> nums = [2, 3, 5, 7];
        int[] result = MinBitwiseArray(nums);
        foreach (int n in result){
            Console.Write(n + " ");
        }
    }
}
