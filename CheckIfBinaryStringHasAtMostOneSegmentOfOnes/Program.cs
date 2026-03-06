namespace CheckIfBinaryStringHasAtMostOneSegmentOfOnes;

internal class Program
{
    private static bool CheckOnesSegment(string s)
    {
        int n = s.Length;
        for (int i = 0; i < n; i++)
        {
            if (s[i] == '0')
            {
                while (i < n)
                {
                    if (s[i] == '1') return false;
                    i++;
                }
            }
        }

        return true;
    }

    static void Main(string[] args)
    {
        string s = "1100001000";
        bool result = CheckOnesSegment(s);
        Console.WriteLine(result);
    }
}
