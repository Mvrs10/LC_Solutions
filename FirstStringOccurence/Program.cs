using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
