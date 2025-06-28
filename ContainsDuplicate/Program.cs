namespace ContainsDuplicate;
internal class Program
{
    private static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        foreach (int x in nums)
        {
            if (set.Contains(x)) return true;
            else set.Add(x);
        }
        return false;
    }
    private static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int,int> map = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i], i);
            }
            else
            {
                if (Math.Abs(i - map[nums[i]]) <= k) return true;
                else map[nums[i]] = i;
            }
        }
        return false;
    }
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 6 };
        bool result = ContainsDuplicate(nums);
        int[] nums1 = { 1, 0, 1, 1 };
        Console.WriteLine(result);
        result = ContainsNearbyDuplicate(nums1, 1);
        Console.WriteLine(result);
    }
}
