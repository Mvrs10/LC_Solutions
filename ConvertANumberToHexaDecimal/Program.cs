using System.Text;

namespace ConvertANumberToHexaDecimal;

internal class Program
{
    private static string ToHex(int num)
    {
        if (num == 0) return "0";
        string hex = "0123456789abcdef";
        StringBuilder sb = new StringBuilder();

        uint n = (uint)num;
        while (n > 0)
        {
            int digit = (int)(n % 16);
            sb.Insert(0, hex[digit]);
            n /= 16;
        }
        
        return sb.ToString();
    }
    static void Main(string[] args)
    {
        int num = 16;
        string result = ToHex(num);
        Console.WriteLine(result);
    }
}
