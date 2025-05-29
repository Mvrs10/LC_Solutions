using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove that duplicator!");
        }

        public int RemoveDuplicates(int[] nums)
        {
            int k = 1, count = 0, duplicates = 0;
            for (int i = 0; i< nums.Length; i++)
            {
                if (i == nums.Length - 1) break;
                if (nums[i] == nums[i+1])
                {
                    duplicates++;
                }
                else
                {
                    
                    int unique = nums[i + 1];
                    count = duplicates;
                    while (count > 0)
                    {
                        nums[i - count] = unique;
                        count--;
                    }
                    k++;
                }
            }
            return k;
        }
    }
}
