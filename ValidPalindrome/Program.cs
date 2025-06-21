using System;
using System.Text.RegularExpressions;


namespace ValidPalindrome
{
    internal class Program
    {
        private static bool IsPalindromeWithRegularExpressions(string s)
        {
            string sanitizedS = Regex.Replace(s.ToLower(), "[^a-z0-9]", "");
            int first = 0, last = sanitizedS.Length - 1;
            while (first < last)
            {
                if (sanitizedS[first] != sanitizedS[last])
                {
                    return false;
                }
                first++;
                last--;
            }
            return true;
        }

        private static bool IsPalindromeWithoutRegex(string s)
        {
            int first = 0, last = s.Length - 1;
            s = s.ToLower();
            while (first < last)
            {
                while (first < last && !char.IsLetterOrDigit(s[first]))
                {
                    first++;
                }
                while (last > first && !char.IsLetterOrDigit(s[last]))
                {
                    last--;
                }
                if (s[first] != s[last])
                {
                    return false;
                }
                first++;
                last--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome!!");
            string s1 = "A man, a plan, a canal: Panama";
            string s2 = " ";
            bool result = IsPalindromeWithRegularExpressions(s1);
            Console.WriteLine(result);
            result = IsPalindromeWithoutRegex(s1);
            Console.WriteLine(result);
            result = IsPalindromeWithRegularExpressions(s2);
            Console.WriteLine(result);
        }
    }
}
