using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
        /* Constraint
         *  2 <= nums.length <= 10^4
         *  -10^9 <= nums[i] <= 10^9
         *  -10^9 <= target <= 10^9
         */
        public int[] Two_Sum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j) continue;
                    if (nums[j] == target - nums[i]) return new int[] { i, j }; 
                }
            }
            return null;
        }
    }
}
