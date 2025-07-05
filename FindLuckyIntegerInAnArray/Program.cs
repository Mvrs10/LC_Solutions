namespace FindLuckyIntegerInAnArray;

internal class Program
{
    private static int FindLucky(int[] arr)
    {
        int n = arr.Length;
        int[] freqTable = new int[n];
        foreach (int i in arr)
        {
            if (i <= n) freqTable[i - 1]++;
        }
        for (int i = n - 1; i >=0; i--)
        {
            if (freqTable[i] == i + 1) return i+1;
        }
        return -1;
    }

    private static int FindLuckyHashMap(int[] arr)
    {
        Dictionary<int,int> freqTable = new Dictionary<int,int>();
        foreach (int i in arr)
        {
            if (!freqTable.ContainsKey(i)) freqTable[i] = 1;
            else freqTable[i]++;
        }
        int currentLucky = -1;
        foreach (KeyValuePair<int,int> pair in freqTable)
        {
            if(pair.Key == pair.Value && pair.Key > currentLucky) currentLucky = pair.Key; 
        }
        return currentLucky;
    }
    static void Main(string[] args)
    {
        int[] nums1 = [2, 2, 3, 4];
        int[] nums2 = [3, 1, 2, 3, 3, 2];
        int result = FindLucky(nums1);
        Console.WriteLine(result);
        result = FindLucky(nums2);
        Console.WriteLine(result);
    }
}
