namespace TheTwoSneakyNumbersOfDigitville;

internal class Program
{
    private static int[] GetSneakyNumber(int[] nums)
    {
        int[] result = new int[2];
        int[] count = new int[100];
        int index = 0;

        foreach(int num in nums)
        {
            count[num]++;

            if (count[num] == 2)
            {
                result[index] = num;
                index++;
            }
            if (index == 2)
                break;
        }

        return result;
    }
    static void Main(string[] args)
    {
        int[] nums = [1, 0, 1, 0];
        int[] result = GetSneakyNumber(nums);
        foreach (int n in result)
        {
            Console.WriteLine(n);
        }
    }
}
