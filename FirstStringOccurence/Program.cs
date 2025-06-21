using System;

namespace FirstStringOccurence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Needle in a haystack");
            int result = MyStrStr("mississippi", "issipi");
            Console.WriteLine(result);
        }

        static int MyStrStr(string haystack, string needle)
        {
            int matchingCharacters = 0;
            for (int i = 0; i < haystack.Length - needle.Length; i++)
            {
                while (haystack[i + matchingCharacters] == needle[0 + matchingCharacters])
                {
                    matchingCharacters++;
                    if (matchingCharacters == needle.Length) return i;
                }
                matchingCharacters = 0;
            }
            return -1;
        }

        static int StrStr(string haystack, string needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle) return i;
            }
            return -1;
        }
    }
}
