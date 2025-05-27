using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Romans");
        }
        public int RomanToInt(string roman)
        {
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                {'I',1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },
                {'D',500 },
                {'M',1000 },
            };
            char[] chars = roman.ToCharArray();
            int result = 0, prev = 0;
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                int value = map[chars[i]];
                if (map[chars[i]] > prev)
                {
                    result = result + value;
                }
                else result = result - value;
                prev = result;
            }
            return result;
        }
    }
}
