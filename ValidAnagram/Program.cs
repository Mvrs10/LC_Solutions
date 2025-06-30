namespace ValidAnagram;

internal class Program
{
    private static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;        
        List<char> listS = s.ToList();
        foreach (char c in t)
        {
            if (!listS.Remove(c))
                return false;
        }
        return true;
    }
    
    private static bool IsAnagramFrequencyTable(string s, string t)
    {
        if (s.Length != t.Length) return false;
        int BASE = 97;
        int[] freqTable = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            freqTable[s[i] - BASE]++;
            freqTable[t[i] - BASE]--;
        }
        foreach (int i in freqTable)
        {
            if (i != 0) return false;
        }
        return true;
    }
    static void Main(string[] args)
    {
        string s = "anagram";
        string t = "ganaram";
        bool result = IsAnagram(s, t);
        Console.WriteLine(result);
        result = IsAnagramFrequencyTable(s, t);
        Console.WriteLine(result);
    }
}
