using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    internal class Program
    {
        private static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int>(1) { 1 });
            for (int i = 1; i <= numRows - 1; i++)
            {
                IList<int> row = new List<int>(i+1);
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        row.Add(result[i-1][j - 1] + result[i-1][j]);
                    }
                }
                result.Add(row);
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Pascal Triangle");
            IList<IList<int>> result = Generate(5);
            Console.WriteLine(result);
        }
    }
}
