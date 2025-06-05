using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace PlusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quick math!");
            Console.WriteLine(100/99);
            int[] result = PlusOneWithSmartCode(new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 });
            foreach (int i in result)
            {
                Console.Write($"{i}, ");
            }
        }
        
        static int[] PlusOne(int[] digits)
        {
            if (digits[digits.Length - 1] != 9)
            {
                digits[digits.Length - 1] += 1;
                return digits;
            }
            bool isPowerOfTen = true;
            for (int i = 0; i < digits.Length - 1; i++)
            {
                if (digits[i] != 9)
                {
                    isPowerOfTen = false;
                }
            }
            if (isPowerOfTen)
            {
                int[] newDigits = new int[digits.Length + 1];
                newDigits[0] = 1;
                return newDigits;
            }
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i] += 1;
                    break;
                }
            }
            return digits;
        }

        static int[] PlusOneWithSmartCode(int[] digits)
        {
            int one = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] += one;
                if (digits[i] < 10)
                {
                    return digits;
                }
                digits[i] = 0;
            }
            int[] newDigits = new int[digits.Length + 1];
            newDigits[0] = one;
            return newDigits;
        }
    }
}
