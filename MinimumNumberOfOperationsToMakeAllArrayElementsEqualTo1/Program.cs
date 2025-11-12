namespace MinimumNumberOfOperationsToMakeAllArrayElementsEqualTo1;

internal class Program
{
    private static int MinOperations(int[] nums)
    {
        int n = nums.Length;

        int FindGCD(int num1,  int num2)
        {
            while(num2 > 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            return num1;
        }

        int numsGCD = nums[0];
        for (int i = 1; i < n; i++)
        {
            numsGCD = FindGCD(nums[i], numsGCD);
        }
        if (numsGCD > 1) return -1;

        int ones = 0;
        foreach (int num in nums)
        {
            if (num == 1) ones++;
        }
        if (ones > 0) return n - ones;

        int shortestSubarray = n;
        for (int i = 0; i < n; i++)
        {
            numsGCD = nums[i];
            for (int j = i + 1; j < n; j++)
            {
                numsGCD = FindGCD(nums[j], numsGCD);
                if (numsGCD == 1)
                {
                    shortestSubarray = Math.Min(shortestSubarray, j - i + 1);
                    break;
                }
            }
        }
        return shortestSubarray - 1 + n - 1;
    }
    static void Main(string[] args)
    {
        int[] nums1 = [2, 6, 3, 4];
        int result = MinOperations(nums1);
        Console.WriteLine(result);
    }
}
