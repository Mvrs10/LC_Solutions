namespace TransfomedArray;

internal class Program
{
    private static int[] ConstructTransformedArray(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];

        for (int i = 0; i < n; i++)
        {
            int count = nums[i] < 0 ? -nums[i] : nums[i];
            int j = i;
            while (count > 0)
            {
                if (nums[i] < 0)
                    j--;
                else
                    j++;

                if (j == n)
                    j = 0;
                if (j == -1)
                    j = n - 1;

                count--;
            }
            result[i] = nums[j];
        }
        return result;
    }

    static void Main(string[] args)
    {
        int[] nums = [3, -2, 1, 1];
        int[] result = ConstructTransformedArray(nums);
        foreach (int i in result)
        {
            Console.WriteLine(i);
        }
    }
}
