namespace Counting_Bits;

internal class Program
{
    private static int[] CountBits(int n)
    {
        int[] ans = new int[n + 1];
        for (int i = 0; i < ans.Length; i++)
        {            
            int j = i;            
            while (j > 0)
            {
                if (j % 2 == 1) ans[i]++;
                j /= 2;
            }
        }
        return ans;
    }

    private static int[] CountBits_v2(int n)
    {
        int[] ans = new int[n + 1];
        for (int i = 0; i < ans.Length; i++)
        {
            ans[i] = ans[i >> 1] + (i & 1);
        }
        return ans;
    }

    static void Main(string[] args)
    {
        int[] result = CountBits(16);
        foreach (int i in result) Console.Write(i);
        Console.WriteLine(Environment.NewLine);
        result = CountBits_v2(16);
        foreach (int i in result) Console.Write(i);
    }
}
