namespace MaxiumumNumberOfWordsYouCanType;

internal class Program
{
    private static int CanBeTypedWords(string text, string brokenLetters)
    {
        int count = 0;
        string[] words = text.Split(' ');
        char[] brokenChars = brokenLetters.ToCharArray();
        foreach (string word in words)
        {
            foreach (char c in brokenChars)
            {
                if (word.Contains(c))
                {
                    count++;
                    break;
                }
            }
        }

        return words.Length - count;
    }
    static void Main(string[] args)
    {
        int ans = CanBeTypedWords("leet code", "lt");
        Console.WriteLine(ans);
    }
}
