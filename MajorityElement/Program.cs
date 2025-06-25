using System;


namespace MajorityElement
{
    internal class Program
    {
        private static int MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            int count = 1;
            int result = nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > nums.Length / 2)
                {
                    result = nums[i];
                    break;
                }
            }
            return result;
        }

        private static int MajorityElementByBoyer_Moore(int[] nums)
        {
            int count = 0;
            int candidate = 0;
            foreach (int num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                }
                count += (candidate == num) ? 1 : -1;
            }
            return candidate;
        }
        static void Main(string[] args)
        {
            int[] nums1 = { 3, 2, 3 };
            int[] nums2 = { 2, 2, 1, 5, 1, 2, 2 };
            int result = MajorityElement(nums1);
            Console.WriteLine(result);
            result = MajorityElement(nums2);
            Console.WriteLine(result);
            result = MajorityElementByBoyer_Moore(nums1);
            Console.WriteLine(result);
            result = MajorityElementByBoyer_Moore(nums2);
            Console.WriteLine(result);
        }
    }
}
