namespace IntersectionOfTwoArrays;

internal class Program
{
    private static int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> ans = new HashSet<int>();
        bool isNums1Shorter = nums1.Length < nums2.Length;
        HashSet<int> hs = new HashSet<int>(isNums1Shorter ? nums2 : nums1);
        if (isNums1Shorter)
        {
            foreach (int i in nums1)
            {
                if (hs.Contains(i) && !ans.Contains(i)) ans.Add(i);
            }
        }
        else
        {
            foreach (int i in nums2)
            {
                if (hs.Contains(i) && !ans.Contains(i)) ans.Add(i);
            }
        }
        return [.. ans];
    }

    public int[] Intersection_v2(int[] nums1, int[] nums2)
    {
        HashSet<int> ans = new HashSet<int>();
        HashSet<int> hs_nums2 = new HashSet<int>(nums2);
        for (int i = 0; i < nums1.Length; i++)
        {
            if (hs_nums2.Contains(nums1[i]))
            {
                ans.Add(nums1[i]);
            }
        }
        return [..ans];
    }
    static void Main(string[] args)
    {
        int[] nums1 = [1, 2, 2, 1];
        int[] nums2 = [2, 2];
        int[] result =  Intersection(nums1, nums2);
        Console.WriteLine(result.ToString());

        int[] nums3 = [11];
        int[] nums4 = [9, 4, 9, 8, 4];
        result = Intersection(nums3, nums4);
        Console.WriteLine(result.ToString());
    }
}
