namespace UniqueLength3PalindromicSubsequences;

internal class Program
{
    private static int CountPalindromicSequence(string s)
    {
        int n = s.Length;

        int[] left = new int[26];
        int[] right = new int[26];

        for (int i = 0; i < 26; i++)
        {
            left[i] = -1;
            right[i] = -1;
        }

        for (int i = 0; i < n; i++)
        {
            if (left[s[i] - 'a'] == -1)
                left[s[i] - 'a'] = i;
        }

        for (int i = n - 1; i >= 0; i--)
        {
            if (right[s[i] - 'a'] == -1)
                right[s[i] - 'a'] = i;
        }

        int result = 0;
        for (int i = 0; i < 26; i++)
        {
            int l = left[i];
            int r = right[i];

            if (l != -1 && r != -1 && l < r)
            {
                HashSet<char> unique = new HashSet<char>();

                for (int j = l + 1; j < r; j++)
                {
                    unique.Add(s[j]);
                }

                result += unique.Count;
            }
        }

        return result;
    }
    static void Main(string[] args)
    {
        string s = "aabca";
        int result = CountPalindromicSequence(s);
        Console.WriteLine(result);
    }
}
