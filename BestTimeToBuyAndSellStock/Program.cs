using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BestTimeToBuyAndSellStock
{
    internal class Program
    {
        private static int MaxProfit(int[] prices)
        {
            int max = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    int profit = prices[j] - prices[i];
                    if (profit > 0 && profit > max)
                    {
                        max = profit;
                    }
                }
            }
            return max;
        }

        private static int MaxProfit2(int[] prices)
        {
            int max = 0;
            int min = int.MaxValue;
            foreach (int price in prices)
            {
                if (price < min)
                {
                    min = price;
                }
                else
                {
                    max = Math.Max(max, price - min);
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            //int[] prices = new int[] { 0, 0, 0, 0, 0, 0 };
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            //int[] prices = new int[] { 8, 7, 6, 5, 4, 3 };
            int result = MaxProfit(prices);
            result = MaxProfit2(prices);
            Console.WriteLine(result);
        }
    }
}
