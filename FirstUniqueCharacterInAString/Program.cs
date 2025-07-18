namespace FirstUniqueCharacterInAString;

internal class Program
{
    private static int FirstUniqChar(string s)
    {
        if (s.Length == 1) return 0;
        Dictionary<char,int> letters = new Dictionary<char,int>();
        foreach(char c in s)
        {
            if (!letters.ContainsKey(c))
                letters[c] = 0;
            letters[c]++;
        }

        char unique = '#';
        foreach(KeyValuePair<char,int> kvp in letters)
        {
            if (kvp.Value == 1)
            {
                unique = kvp.Key;
                break;
            }
        }

        if (unique == '#') return -1;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == unique) return i;
        }
        return -1;
    }
    static void Main(string[] args)
    {
        int result = FirstUniqChar("leetcode");
        Console.WriteLine(result);
        result = FirstUniqChar("loveleetcoding");
        Console.WriteLine(result);
        result = FirstUniqChar("aabbcc");
        Console.WriteLine(result);
    }
}
