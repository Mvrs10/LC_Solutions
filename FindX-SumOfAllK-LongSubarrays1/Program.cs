namespace FindX_SumOfAllK_LongSubarrays1;

internal class Program
{
    private static int XSum(Dictionary<int,int> freq, int x)
    {
        IEnumerable<KeyValuePair<int,int>> top = freq
                                                    .OrderByDescending(p => p.Value)
                                                    .ThenByDescending(p => p.Key)
                                                    .Take(x);

        int sum = 0;
        foreach (KeyValuePair<int,int> p in top)
        {
            sum += p.Key * p.Value;
        }

        return sum;
    }
    private static int[] FindXSum(int[] nums, int k, int x)
    {
        int n = nums.Length;
        IList<int> result = new List<int>();

        for (int i = 0; i + k <= n; i++)
        {
            Dictionary<int,int> freq = new Dictionary<int,int>();
            for (int j = i; j < i + k; j++)
            {
                if (!freq.ContainsKey(nums[j]))
                    freq[nums[j]] = 0;
                freq[nums[j]]++;
            }

            result.Add(XSum(freq, x));
        }

        return [.. result];
    }
    static void Main(string[] args)
    {
        int[] nums = [1, 1, 2, 2, 3, 4, 2, 3];
        int k = 6;
        int x = 2;

        int[] result = FindXSum(nums, k, x);
        foreach (int r in result)
        {
            Console.WriteLine(r);
        }
    }
}
