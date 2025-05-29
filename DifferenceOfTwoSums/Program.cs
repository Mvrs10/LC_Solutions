using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceOfTwoSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Difference of Two Sums (Non-divisible and divisible)");
            int result = DifferenceOfTwoSums(10, 3);
        }

        public static int DifferenceOfTwoSums(int n, int m)
        {
            int num1 = 0, num2 = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % m != 0) num1 += i;
                else num2 += i;
            }
            return num1 - num2;
        }
    }
}
