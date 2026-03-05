namespace MinimumChangesToMakeAlternatingBinaryString;

internal class Program
{
    private static int MinOperations(string s)
    {
        int oneZero = 0;
        int zeroOne = 0;

        char current = '0';
        foreach (char c in s)
        {
            if (c == current)
            { 
                oneZero++;
            }
            current = (current == '1') ? '0' : '1';
        }

        current = '1';
        foreach (char c in s)
        {
            if (c == current)
            {
                zeroOne++;
            }
            current = (current == '1') ? '0' : '1';
        }

        return Math.Min(oneZero, zeroOne);
    }

    static void Main(string[] args)
    {
        string s = "100001";
        int result = MinOperations(s);
        Console.WriteLine(result);
    }
}
