using System;
using System.Text;

namespace AddBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do math addition");
            string a = "Hello";
            string b = "World";
            a = b + a;
            Console.WriteLine(a);
            a = AddBinary("1111", "11");
            Console.WriteLine(a);
        }

        static string AddBinary(string a, string b)
        {
            int x = a.Length;
            int y = b.Length;
            int carry = 0;
            StringBuilder sb = new StringBuilder();
            while (x > 0 || y > 0 || carry != 0)
            {
                int numA = (x > 0) ? a[x - 1] - '0' : 0;
                int numB = (y > 0) ? b[y - 1] - '0' : 0;
                int sum = carry + numA + numB;
                carry = sum / 2;
                int digit = sum % 2;
                sb.Insert(0, digit);
                x--;
                y--;
            }
            return sb.ToString();
        }
    }
}
