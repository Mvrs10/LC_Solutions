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

        private static IList<int> GetRow(int rowIndex)
        {
            IList<int> result = new List<int>(new int[rowIndex + 1]);
            result[0] = 1;
            for (int i = 1; i <= rowIndex; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    result[j] = result[j] + result[j - 1];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Pascal Triangle");
            IList<IList<int>> result = Generate(5);
            IList<int> result2 = GetRow(1);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
