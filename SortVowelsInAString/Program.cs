namespace SortVowelsInAString;

internal class Program
{
    private static bool IsVowel(char c)
    {
        if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' || c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            return true;
        return false;
    }
    private static string SortVowels(string s)
    {
        char[] vowels = new char[s.Length];
        char[] t = new char[s.Length];
        
        for (int i = 0, j = 0; i < s.Length; i++)
        {
            if (IsVowel(s[i]))
            {
                vowels[j] = s[i];
                j++;
            }                
            else
                t[i] = s[i];
        }

        Array.Sort(vowels);

        for (int i = t.Length - 1, j = vowels.Length - 1; i >= 0; i--)
        {
            if (t[i] == '\0')
            {
                t[i] = vowels[j];
                j--;
            }
        }

        return new string(t);
    }
    static void Main(string[] args)
    {
        string result = SortVowels("lEetcOde");
        Console.WriteLine(result);
    }
}
