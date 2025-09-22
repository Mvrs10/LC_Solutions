namespace CountElementsWithMaximumFrequency;

internal class Program
{
    private static int MaximumFrequencyElements(int[] nums)
    {
        Dictionary<int,int> freqTable = new Dictionary<int,int>();
        int max = 1;
        int sum = 0;

        foreach (int i in nums)
        {
            if (!freqTable.ContainsKey(i))
                freqTable[i] = 0;
            freqTable[i]++;
        }

        foreach (KeyValuePair<int, int> kvp in freqTable)
        {
            if (kvp.Value > max)
            {
                max = kvp.Value;
                sum = max;
            }
            else if (kvp.Value == max)
                sum += max;
        }

        return sum;
    }
    static void Main(string[] args)
    {
        int result = MaximumFrequencyElements([1, 2, 2, 3, 1, 4]);
        Console.WriteLine(result);
    }
}
