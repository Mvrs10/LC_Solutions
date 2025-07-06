namespace FindingPairsWithACertainSum;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums1 = [1, 1, 2, 2, 2, 3];
        int[] nums2 = [1, 4, 5, 2, 5, 4];
        FindSumPairs obj = new FindSumPairs(nums1, nums2);
        int r1 = obj.Count(7);
        Console.WriteLine(r1);
        obj.Add(3, 2);
        r1 = obj.Count(8);
        Console.WriteLine(r1);
        r1 = obj.Count(4);
        Console.WriteLine(r1);
        obj.Add(0, 1);
        obj.Add(1, 1);
        r1 = obj.Count(11);
        Console.WriteLine(r1);
    }
}
