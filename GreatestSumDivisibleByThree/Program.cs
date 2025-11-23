namespace GreatestSumDivisibleByThree;

internal class Program
{
    private static int MaxSumDivThree(int[] nums)
    {
        int[] dp = new int[] { 0, int.MinValue, int.MinValue };

        foreach (int x in nums)
        {
            int[] next = (int[])dp.Clone();

            foreach (int r in new int[] { 0, 1, 2 })
            {
                if (dp[r] != int.MinValue)
                {
                    int nr = (r + x) % 3;
                    next[nr] = Math.Max(next[nr], dp[r] + x);
                }
            }

            dp = next;
        }

        return dp[0];
    }
    static void Main(string[] args)
    {
        int[] nums = [3, 6, 5, 1, 8];
        int result = MaxSumDivThree(nums);
        Console.WriteLine(result);
    }
}
