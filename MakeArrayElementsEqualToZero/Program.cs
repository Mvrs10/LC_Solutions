namespace MakeArrayElementsEqualToZero;

internal class Program
{
    private static int CountValidSelection(int[] nums)
    {
        int count = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {                
                if (IsValid(nums,i,1))
                    count++;
                if (IsValid(nums,i,-1))
                    count++;
            }
        }
        return count;
    }

    private static bool IsValid(int[] nums, int i, int direction)
    {
        int[] clone = (int[])nums.Clone();
        while (i >= 0 && i < clone.Length)
        {
            if (clone[i] > 0)
            {
                clone[i]--;
                direction *= -1;
            }
            i += direction;
        }

        foreach (int v in clone)
        {
            if (v != 0)
                return false;
        }
        return true;
    }
    static void Main(string[] args)
    {
        int[] nums = [1, 0, 2, 0, 3];
        int result = CountValidSelection(nums);
        Console.WriteLine(result);
    }
}
