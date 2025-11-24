namespace BinaryPrefixDivisibleByFive;

internal class Program
{
    private static IList<bool> PrefixesDivBy5(int[] nums)
    {
        IList<bool> isDivBy5 = new List<bool>();
        int current = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            current = (2*current + nums[i]) % 5;
            isDivBy5.Add(current % 5 == 0);
        }

        return isDivBy5;
    }
    static void Main(string[] args)
    {
        int[] nums = [1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 1];
        IList<bool> result = PrefixesDivBy5(nums);
        foreach (bool r in result)
        {
            Console.WriteLine(r);
        }
    }
}
