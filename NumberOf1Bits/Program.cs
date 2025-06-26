namespace NumberOf1Bits;

internal class Program
{
    private static int HammingWeightStringConversion(int n)
    {
        int count = 0;
        string binary = Convert.ToString(n, 2);
        foreach (char c in binary)
        {
            count += (c == 49) ? 1 : 0;
        }
        return count;
    }
    private static int HammingWeightNoStringConversion(int n)
    {
        int count = 0;
        while (n > 0)
        {
            int mod = n % 2;
            count += (mod == 1) ? 1 : 0;
            n /= 2;
        }
        return count;
    }
    static void Main(string[] args)
    {
        int n1 = 11;
        int n2 = 2147483645;
        int result = HammingWeightNoStringConversion(n1);
        Console.WriteLine(result);
        result = HammingWeightNoStringConversion(n2);
        Console.WriteLine(result);
        result = HammingWeightStringConversion(n2);
        Console.WriteLine(result);
    }
}
