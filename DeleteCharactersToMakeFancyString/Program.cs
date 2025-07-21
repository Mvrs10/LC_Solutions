using System.Text;

namespace DeleteCharactersToMakeFancyString;

internal class Program
{
    private static string MakeFancyString(string s)
    {
        StringBuilder sb = new StringBuilder();
        int i = 0;
        int count = 1;
        while (i < s.Length - 1)
        {
            if (s[i] != s[i + 1])
            {
                sb.Append(s[i]);
                count = 1;
            }                
            else if (count < 2)
            {
                sb.Append(s[i]);
                count++;
            }
            i++;
        }
        sb.Append(s[s.Length - 1]);
        return sb.ToString();
    }
    static void Main(string[] args)
    {
        string s1 = "leeeeetcodeeeee";
        string result = MakeFancyString(s1);
        Console.WriteLine(result);
    }
}
