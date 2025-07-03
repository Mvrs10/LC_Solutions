using System.Text;

namespace FindTheKthCharacterInStringGame1;

internal class Program
{
    private static string GenerateWord(string word, int limit)
    {
        if (word.Length >= limit) return word;
        StringBuilder sb = new StringBuilder(word);
        foreach(char c in word)
        {
            sb.Append((c == 'z') ? 'a' : (char)(c + 1));
        }
        return GenerateWord(sb.ToString(), limit);
    }
    private static char KthCharacter(int k)
    {
        string result = GenerateWord("a", k);
        return result[k-1];
    }
    static void Main(string[] args)
    {
        int k = 10;
        char result = KthCharacter(k);
        Console.WriteLine(result);
    }
}
