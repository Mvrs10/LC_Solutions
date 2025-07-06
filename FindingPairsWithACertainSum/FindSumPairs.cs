namespace FindingPairsWithACertainSum;

internal class FindSumPairs
{
    private readonly int[] _nums1;
    private readonly int[] _nums2;
    private readonly Dictionary<int, int> freqTable = new Dictionary<int,int>();

    public FindSumPairs(int[] nums1, int[] nums2)
    {
        _nums1 = nums1;
        Array.Sort(_nums1);
        _nums2 = nums2;
        foreach (int i in nums2)
        {
            if (!freqTable.ContainsKey(i)) freqTable[i] = 0;
            freqTable[i]++;              
        }
    }

    public void Add(int index, int val)
    {
        int v = _nums2[index];
        _nums2[index] += val;
        // Update freqTable
        freqTable[v]--;
        if (freqTable[v] == 0) freqTable.Remove(v);

        v = _nums2[index];
        if (!freqTable.ContainsKey(v)) freqTable[v] = 0;
        freqTable[v]++;
    }

    public int Count(int tot)
    {
        int sumPairs = 0;
        int index = 0;
        while (index < _nums1.Length && _nums1[index] < tot)
        {
            int complement = tot - _nums1[index];
            if(freqTable.ContainsKey(complement)) sumPairs += freqTable[complement];
            index++;
        }
        return sumPairs;
    }
}
