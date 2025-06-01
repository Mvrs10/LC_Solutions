using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove the guy");
            int result = RemoveElement(new int[] { 2, 2, 2, 3 }, 2);
            Console.WriteLine(result);
        }

        static int RemoveElement(int[] nums, int val)
        {
            int repeat = 0;
            for (int i = 0; i < nums.Length - repeat; i++)
            {
                if (nums[i] == val)
                {
                    repeat++;
                    while (nums[nums.Length - repeat] == val && nums.Length - repeat != i)
                    {
                        repeat++;
                    }
                    if (nums.Length - repeat == i) break;
                    int temp = nums[nums.Length - repeat];
                    nums[nums.Length - repeat] = val;
                    nums[i] = temp;
                }
            }
            nums = nums.Take(nums.Length - repeat).ToArray();
            return nums.Length;
        }
    }
}
