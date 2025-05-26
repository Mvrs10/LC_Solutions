using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            string stringX = x.ToString();
            char[] array = stringX.ToCharArray();
            int begin = 0, end = array.Length - 1;
            while (begin < end)
            {
                (array[begin], array[end]) = (array[end], array[begin]);
                begin++;
                end--;
            }
            string reverseStringX = new string(array);
            return stringX == reverseStringX;
        }
    }
}
