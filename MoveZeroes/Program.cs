namespace MoveZeroes;

internal class Program
{
    private static void MoveZeroes(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == 0)
            {
                int firstZeroIndex = i;
                int checkpoint = firstZeroIndex;
                while (i < nums.Length - 1 && firstZeroIndex == checkpoint)
                {
                    if (nums[++i] != 0)
                    {
                        nums[firstZeroIndex] = nums[i];
                        nums[i] = 0;
                        firstZeroIndex++;
                    }
                }
                i = checkpoint;
            }
        }
    }

    private static void MoveZeroes_v2(int[] nums)
    {
        int zeroIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[zeroIndex++] = nums[i];
            }
        }
        while (zeroIndex < nums.Length)
        {
            nums[zeroIndex++] = 0;
        }
    }

    static void Main(string[] args)
    {
        int[] nums1 = [0, 1, 0, 3, 12];
        MoveZeroes(nums1);
        foreach (int i in nums1)
        {
            Console.WriteLine(i);
        }
    }
}
