namespace SummaryRange;

internal class Program
{
    private static IList<string> SummaryRange(int[] nums)
    {
        IList<string> result = new List<string>();
        string arrow = "->";
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            string start = nums[i].ToString();
            while (i < n - 1 && nums[i] == nums[i+1] - 1)
            {
                i++;
            }
            string end = nums[i].ToString();
            string range = (start != end) ? start + arrow + end : start;
            result.Add(range);
        }
        return result;
    }
    static void Main(string[] args)
    {
        int[] nums = { 1, 4, 5, 6, 8 };
        IList<string> result = SummaryRange(nums);
        foreach(string range in result)
        {
            Console.WriteLine(range);
        }
    }
}
