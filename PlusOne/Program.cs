using System;
using System.Collections.Generic;
using System.Linq;
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
        }
        
        static int[] PlusOne(int[] digits)
        {
            if (digits[digits.Length - 1] != 9)
            {
                digits[digits.Length - 1] += 1;
                return digits;
            }
            //int num = 0;
            //for (int i = digits.Length - 1; i >= 0; i--)
            //{
            //    num += digits[i] * (int)Math.Pow(10, digits.Length - 1 - i);
            //}
            //num += 1;
            //if(num%10 == 0)
            //{
            //    int[] returnDigits = new int[digits.Length + 1];
            //}
            bool isMultipleOfTens = true;
            for (int i = 0; i < digits.Length - 1; i++)
            {
                if (digits[i] != 9)
                {
                    isMultipleOfTens = false;
                }
            }
            if (isMultipleOfTens)
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
    }
}
