using System.Text;

namespace AddStrings;

internal class Program
{
    private static string AddStrings(string num1, string num2)
    {
        StringBuilder sb = new StringBuilder();
        int m = num1.Length - 1;
        int n = num2.Length - 1;
        int carry = 0;
        const int BASE = '0';

        while (m >= 0 || n >= 0 || carry > 0)
        {
            int digit1 = m >= 0 ? num1[m] - BASE : 0;
            int digit2 = n >= 0 ? num2[n] - BASE : 0;
            int sum = digit1 + digit2 + carry;
            sb.Insert(0, sum % 10);
            carry = sum / 10;
            m--;
            n--;
        }

        return sb.ToString();
    }
    static void Main(string[] args)
    {
        string num1 = "12";
        string num2 = "28";

        string result = AddStrings(num1, num2);
        Console.WriteLine(result);
    }
}
