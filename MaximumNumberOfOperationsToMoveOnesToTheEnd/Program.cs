namespace MaximumNumberOfOperationsToMoveOnesToTheEnd;

internal class Program
{
    private static int MaxOperations(string s)
    {
        int ops = 0, ones = 0;

        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] == '0')
            {
                while (i < s.Length && s[i] == '0')
                    i++;
                ops += ones;
            }
            ones++;
        }

        return ops;
    }
    static void Main(string[] args)
    {
        string s1 = "1001101";
        string s2 = "00111";
        string s3 = "0011010101100";
        string[] s = { s1, s2, s3 };

        foreach (string ss in s)
        {
            Console.WriteLine(MaxOperations(ss));
        }
    }
}
