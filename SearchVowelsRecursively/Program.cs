using System;
using System.Linq;


namespace SearchVowelsRecursively
{
    internal class Program
    {
        private static bool IsVowel(char c)
        {
            string vowels = "AaEeIiOoUu";
            return vowels.Contains(c);
        }

        private static int SearchVowels(string str)
        {
            if (str.Length == 0) return 0;
            char c = str[0];
            int count = IsVowel(c) ? 1 : 0;
            return count + SearchVowels(str.Substring(1));
        }
        static void Main(string[] args)
        {
            string str = " Hello World! ";
            int count = SearchVowels(str);
            Console.WriteLine(count);
        }
    }
}
