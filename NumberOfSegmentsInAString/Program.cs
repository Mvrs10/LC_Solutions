namespace NumberOfSegmentsInAString;

internal class Program
{
    private static int CountSegments(string s)
    {
        int count = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
                continue;
            while (i < s.Length && s[i] != ' ')
            {
                i++;
            }
            count++;
        }

        return count;
    }
    static void Main(string[] args)
    {
        string s = "Hello, my name is John";
        int result = CountSegments(s);
        Console.WriteLine(result);
        s = " aa  ,bbbb     k    ";
        result = CountSegments(s);
        Console.WriteLine(result);
    }
}
