using System;

namespace SingleNumber
{
    internal class Program
    {
        private static int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                result ^= num;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 3, 4, 3, 7, 7, };
            Console.Write("XOR: " + SingleNumber(nums));
        }
    }
}
