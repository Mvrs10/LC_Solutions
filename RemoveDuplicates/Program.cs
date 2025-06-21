using System;

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
                    for (int j = i; count > 0; count--)
                    {
                        nums[j] = unique;
                        j--;
                    }
                    k++;
                }
            }
            return k;
        }

        public int BetterRemoveDuplicates(int[] nums)
        {
            int uniquePtr = 1;
            for (int i = 1; i <  nums.Length; i++)
            {
                if (nums[i] != nums[uniquePtr - 1])
                {
                    nums[uniquePtr] = nums[i];
                    uniquePtr++;
                }
            }
            return uniquePtr;
        }
    }
}
