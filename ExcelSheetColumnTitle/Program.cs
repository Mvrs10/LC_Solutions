using System;
using System.Text;


namespace ExcelSheetColumnTitle
{
    internal class Program
    {
        private static string ConvertToTitle(int columnNumber)
        {
            const int BASE = 64;
            StringBuilder title = new StringBuilder();
            while (columnNumber > 0)
            {                
                int mod = columnNumber % 26;
                if (mod == 0)
                {
                    columnNumber--;
                    mod = 26;
                }
                char letter = (char)(mod + BASE);

                title.Insert(0,letter);
                columnNumber /= 26;
            }
            return title.ToString();
        }
        static void Main(string[] args)
        {
            string result = ConvertToTitle(28);
            Console.WriteLine(result);
        }
    }
}
