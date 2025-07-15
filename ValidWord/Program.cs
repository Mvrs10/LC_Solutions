namespace ValidWord;

internal class Program
{
    private static bool CheckLetter(char c)
    {
        char[] VOWELS = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
        return VOWELS.Contains(c);
    }
    private static bool IsValid(string word)
    {
        if (word.Length < 3) return false;
        bool vowelCount = false;
        bool consonantCount = false;
        foreach (char c in word)
        {
            if (c == '@' || c == '#' || c == '$') return false;
            if ((c >= '0' && c <= '9') || (vowelCount && consonantCount)) continue;
            if (CheckLetter(c) && !vowelCount) vowelCount = true;
            else if(!CheckLetter(c)) consonantCount = true;
        }
        return vowelCount && consonantCount;
    }
    static void Main(string[] args)
    {
        bool result = IsValid("234Adas");
        Console.WriteLine(result);
        result = IsValid("b3");
        Console.WriteLine(result);
        result = IsValid("a3$e");
        Console.WriteLine(result);
        result = IsValid("12345c");
        Console.WriteLine(result);
    }
}
