using System;


namespace LengthOfLastWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Any last words");
            int result = LengthOfLastWord("A B C d    ");
            Console.WriteLine(result);
        }

        static int LengthOfLastWord(string s)
        {
            int count = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    count++;
                }
                else if (count != 0) return count;
            }
            return count;
        }
    }
}
