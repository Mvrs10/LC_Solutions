namespace LongestPalindrome;

internal class Program
{
    private static int LongestPalindrome(string s)
    {
        int[] table = new int[58];
        int count = 0;

        foreach (char c in s)
        {
            int i = c - 'A';
            table[i]++;
            if (table[i] % 2 == 0)
                count += 2;
        }

        foreach(int i in table)
        {
            if (i % 2 != 0)
            {
                count++;
                break;
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        string s = "aaaACbezkuk";
        int result = LongestPalindrome(s);
        Console.WriteLine(result);
        s = "aaaDDDD";
        result = LongestPalindrome(s);
        Console.WriteLine(result);
        s = "zzzzZZZZ";
        result = LongestPalindrome(s);
        Console.WriteLine(result);
    }
}
