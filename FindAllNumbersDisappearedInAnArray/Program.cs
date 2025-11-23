namespace FindAllNumbersDisappearedInAnArray;

internal class Program
{
    private static IList<int> FindDisappearedNumbers(int[] nums)
    {
        IList<int> missingNumbers = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int j = nums[i];
            while (nums[i] != i + 1 && nums[j - 1] != j && nums[i] != nums[j - 1])
            {
                int temp = nums[j - 1];
                nums[j - 1] = j;
                nums[i] = temp;
                j = nums[i];
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i + 1)
                missingNumbers.Add(i + 1);
        }

        return missingNumbers;
    }
    static void Main(string[] args)
    {
        int[] nums = [4, 3, 2, 7, 8, 2, 3, 1];
        IList<int> result = FindDisappearedNumbers(nums);
        foreach(int i in result)
        {
            Console.Write($"{i} ");
        }
    }
}
