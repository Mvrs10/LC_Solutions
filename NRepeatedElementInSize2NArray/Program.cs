namespace NRepeatedElementInSize2NArray;

internal class Program
{
    private static int RepeatedNTimes(int[] nums)
    {
        Dictionary<int,int> track = new Dictionary<int,int>();

        foreach (int n in nums)
        {
            if (!track.ContainsKey(n))
            {
                track[n] = 0;
            }
            track[n]++;
            if (track[n] == nums.Length / 2)
                return n;
        }

        return -1;
    }

    static void Main(string[] args)
    {
        int[] nums = [5, 1, 5, 2, 5, 3, 5, 4];
        int result = RepeatedNTimes(nums);
        Console.WriteLine(result);
    }
}
