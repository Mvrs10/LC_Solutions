namespace IntersectionOfTwoArrays2;

internal class Program
{
    private static int[] Intersect(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);
        List<int> result = new List<int>();
        int n1 = 0, n2 = 0;
        while (n1 < nums1.Length && n2 < nums2.Length)
        {
            if (nums1[n1] == nums2[n2])
            {
                result.Add(nums1[n1]);
                n1++;
                n2++;
            }
            else if (nums1[n1] < nums2[n2]) n1++;
            else n2++;
        }
        return result.ToArray();
    }
    static void Main(string[] args)
    {
        int[] nums1 = [ 1, 2, 2, 1 ];
        int[] nums2 = [ 2 ];
        int[] result = Intersect(nums1, nums2);
        foreach (int i in result)
        {
            Console.WriteLine(i);
        }
    }
}
