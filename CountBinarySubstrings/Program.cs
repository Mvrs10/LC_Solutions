namespace CountBinarySubstrings;

internal class Program
{
    private static int CountBinarySubstrings(string s)
    {
        int result = 0;
        int prev = 0;
        int current = 1;

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                current++;
            }
            else
            {
                result += Math.Min(prev, current);
                prev = current;
                current = 1;
            }
        }

        result += Math.Min(prev, current);

        return result;
    }

    static void Main(string[] args)
    {
        string s = "00110011";
        int result = CountBinarySubstrings(s);
        Console.WriteLine(result);
    }
}
