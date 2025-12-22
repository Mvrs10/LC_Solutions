namespace DeleteColumnsToMakeSorted3;

internal class Program
{
    private static int MinDeletionSize(string[] strs)
    {
        int n = strs.Length;
        int m = strs[0].Length;

        int[] dpLongestPossible = new int[m];
        Array.Fill(dpLongestPossible, 1);

        for (int col = 0; col < m; col++)
        {
            for (int i = 0; i < col; i++)
            {
                bool isLexicographic = true;
                foreach (string str in strs)
                {
                    if (str[i] > str[col])
                    {
                        isLexicographic = false;
                        break;
                    }
                }

                if (isLexicographic)
                {
                    dpLongestPossible[col] = Math.Max(dpLongestPossible[col], dpLongestPossible[i] + 1);
                }
            }
        }

        int longestSubstring = 0;
        foreach (int val in dpLongestPossible)
        {
            longestSubstring = Math.Max(longestSubstring, val);
        }

        return m - longestSubstring;
    }

    static void Main(string[] args)
    {
        string[] strs = ["babca", "bbazb"];
        int result = MinDeletionSize(strs);
        Console.WriteLine(result);
    }
}
