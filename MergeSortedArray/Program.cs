using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge them together!");
            //int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            //int[] nums2 = new int[] { 2, 5, 6 };
            //int m = 3;
            //int n = 3;
            int[] nums1 = new int[] { 4, 0, 0, 0 };
            int[] nums2 = new int[] { 2, 2, 5 };
            int m = 1;
            int n = 3;
            Merge(nums1, m, nums2, n);
            foreach (int i in nums1)
            {
                Console.WriteLine(i);
            }
        }

        private static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int lastOfNums1 = m - 1;
            int lastOfNums2 = n - 1;
            int lastOfMerge = m + n - 1;
            while (lastOfNums1 >= 0 && lastOfNums2 >= 0)
            {
                if (nums2[lastOfNums2] >= nums1[lastOfNums1])
                {
                    nums1[lastOfMerge] = nums2[lastOfNums2];
                    lastOfNums2--;
                }
                else
                {
                    nums1[lastOfMerge] = nums1[lastOfNums1];
                    lastOfNums1--;
                }
                lastOfMerge--;
            }
            for (int i = lastOfNums2; i >=0; i--)
            {
                nums1[lastOfMerge] = nums2[i];
                lastOfMerge--;
            }
        }
    }
}
