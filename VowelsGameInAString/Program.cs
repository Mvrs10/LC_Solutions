namespace VowelsGameInAString;

internal class Program
{
    private static bool DoesAliceWin(string s)
    {
        bool IsVowel(char c)
        {
            if (c == 'a' ||  c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                return true;
            }
            return false;
        }

        int count = 0;

        foreach (char c in s)
        {
            if (IsVowel(c))
                count++;
        }

        return count != 0;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
