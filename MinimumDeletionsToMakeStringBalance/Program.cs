namespace MinimumDeletionsToMakeStringBalance;

internal class Program
{
    private static int MinimumDeletions(string s)
    {
        int aCount = 0, bCount = 0;

        foreach (char c in s)
        {
            if (c == 'a')
                aCount++;
        }

        int i = 0;
        int min = aCount;
        while (i < s.Length)
        {
            if (s[i] == 'a')
                aCount--;
            else
                bCount++;
            min = Math.Min(min, aCount + bCount);
            i++;
        }

        return min;
    }
    static void Main(string[] args)
    {
        string s = "bbbbbbbaab";
        int result = MinimumDeletions(s);
        Console.WriteLine(result);
    }
}
