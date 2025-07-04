namespace MissingNumber;

internal class Program
{
    private static int MissingNumber(int[] nums)
    {
        for (int i = 0; i <= nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == nums[j]) break;
                else if (j == nums.Length - 1 && i != nums[j])
                {
                    return i;
                }
            }
        }
        return nums[0];
    }

    private static int MissingNumberArithmeticSequence(int[] nums)
    {
        int totalOfSequence = ((nums.Length+1) * nums.Length) / 2;
        int sum = 0;
        foreach (int i in nums)
        {
            sum += i;
        }
        return totalOfSequence - sum;
    }
       
    static void Main(string[] args)
    {
        int[] nums = { 0, 1, 3 };
        Console.WriteLine(MissingNumber(nums));
        Console.WriteLine(MissingNumberArithmeticSequence(nums));
    }
}
