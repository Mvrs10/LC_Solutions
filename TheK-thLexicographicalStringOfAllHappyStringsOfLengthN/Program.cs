namespace TheK_thLexicographicalStringOfAllHappyStringsOfLengthN;

internal class Program
{
    private static List<string> HappyStrings = new List<string>();
    private static char[] HappyCharacters = ['a', 'b', 'c'];

    private static string GetHappyString(int n, int k)
    {
        string s = "";
        BuildHappyString(s, n);
        if (HappyStrings.Count < k) return "";
        return HappyStrings[k - 1];
    }

    private static void BuildHappyString(string s, int n)
    {
        if (s.Length == n)
        {
            HappyStrings.Add(s);
            return;
        }

        foreach (char c in HappyCharacters)
        {
            if (s.Length > 0 && c == s.Last()) continue;
            BuildHappyString(s + c, n);
        }
    }

    static void Main(string[] args)
    {
        int n = 1;
        int k = 3;
        string result = GetHappyString(n, k);
        Console.WriteLine(result);
    }
}
