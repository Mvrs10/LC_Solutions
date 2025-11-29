namespace LongestSubstringWithoutRepeatingCharacters;

internal class Program
{
    private static int LengthOfLongestSubstring(string s)
    {
        int n = s.Length;
        int l = 0;
        HashSet<char> seenChars = new HashSet<char>();

        for (int i = 0, j = 0; j < n; i++, j++)
        {
            while (j < n && !seenChars.Contains(s[j]))
            {
                seenChars.Add(s[j++]);
                l = Math.Max(l, j - i);
            }

            while (j < n && s[i] != s[j])
            {
                seenChars.Remove(s[i]);
                i++;
            }
        }

        return l;
    }

    static void Main(string[] args)
    {
        string[] testCases = ["tmmzuxt", "abcabcbb", "bbb", "pwwekw", "abcdaefghijklmn","abbbbbb"];

        foreach (string s in testCases)
        {
            Console.WriteLine(LengthOfLongestSubstring(s));
        }
    }
}
