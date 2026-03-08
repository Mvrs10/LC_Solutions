namespace MinimumNumberOfFlipsToMakeTheBinaryStringAlternating;

internal class Program
{
    private static int MinFlips(string s)
    {
        int n = s.Length;
        string t = s + s;
        int diff1 = 0;
        int diff2 = 0;

        int ans = int.MaxValue;

        for (int i = 0; i < t.Length; i++)
        {
            char expected1 = (i % 2 == 0) ? '0' : '1';
            char expected2 = (i % 2 == 0) ? '1' : '0';

            if (t[i] != expected1) diff1++;
            if (t[i] != expected2) diff2++;

            if (i >= n)
            {
                char oldExpected1 = ((i - n) % 2 == 0) ? '0' : '1';
                char oldExpected2 = ((i - n) % 2 == 0) ? '1' : '0';

                if (t[i - n] != oldExpected1) diff1--;
                if (t[i - n] != oldExpected2) diff2--;
            }

            if (i >= n - 1)
            {
                ans = Math.Min(ans, Math.Min(diff1, diff2));
            }
        }

        return ans;
    }
    static void Main(string[] args)
    {
        string s = "1110000";
        int result = MinFlips(s);
        Console.WriteLine(result);
    }
}
