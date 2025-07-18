namespace RansomNote;

internal class Program
{
    private static bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char,int> magMap = new Dictionary<char,int>();
        foreach (char c in magazine)
        {
            if (!magMap.ContainsKey(c))
                magMap[c] = 0;
            magMap[c]++;
        }

        foreach (char c in ransomNote)
        {
            if (!magMap.ContainsKey(c)) return false;
            else if (magMap[c] == 0) return false;
            else magMap[c]--;
        }
        return true;
    }
    static void Main(string[] args)
    {
        bool result = CanConstruct("a", "b");
        Console.WriteLine(result);
        result = CanConstruct("aa", "ab");
        Console.WriteLine(result);
        result = CanConstruct("hello", "olelhb");
        Console.WriteLine(result);
    }
}
