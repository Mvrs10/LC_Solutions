using System.Text;

namespace CheckIfDigitsAreEqualInStringAfterOperations1;

internal class Program
{
    private static bool HasSameDigits(string s)
    {
        while (s.Length > 2)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length - 1; i++)
            {
                int k = (s[i] - '0' + s[i + 1] - '0');
                sb.Append(k % 10);
            }
            s = sb.ToString();
        }
        return s[0] == s[1];        
    }
    static void Main(string[] args)
    {
        string s = "34789";
        bool result = HasSameDigits(s);
        Console.WriteLine(result);
    }
}
