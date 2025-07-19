namespace FindTheDifference;

internal class Program
{
    private static char FindTheDifference(string s, string t)
    {
        int[] letters = new int[26];
        foreach (char c in s)
        {
            if (!s.Contains(c))
                letters[c - 'a'] = 0;
            letters[c - 'a']++;
        }

        char x = '#';
        foreach (char c in t)
        {
            letters[c - 'a']--;
            if (letters[c - 'a'] == -1)
            {
                x = c;
                break;
            }
        }
        return x;
    }
    static void Main(string[] args)
    {
        char result = FindTheDifference("leetcode", "cteoeidle");
        Console.WriteLine(result);
    }
}
