namespace NumberOfSubstringsWithOnly1s;

internal class Program
{
    private static int NumSub(string s)
    {
        long sum = 0;
        long MOD = 1000000007;

        for (int i = 0; i < s.Length; i++)
        {
            int ones = 0;

            if (s[i] == '1')
            {
                while (i < s.Length && s[i] == '1')
                {
                    ones++;
                    i++;
                }                    
                sum += (long)ones * (ones + 1) / 2;
                sum %= MOD;
            }
        }

        return (int)sum;
    }
    static void Main(string[] args)
    {
        string s = "0110111";
        int result = NumSub(s);
        Console.WriteLine(result);
    }
}
