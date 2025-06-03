using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search in disguise");
            int result = SearchInsert(new int[] { 1, 3, 4, 9, 12, 25, 66, 198 }, 4);
            Console.WriteLine();
        }

        static int SearchInsert(int[] nums, int target)
        {
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] > target) high = mid - 1;
                else low = mid + 1;
            }
            return low;
        }
    }
}
