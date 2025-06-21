using System;

namespace ConvertSortedArrayIntoBST
{
    internal class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        private static TreeNode MakeCluster(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }
            int mid = (left + right) / 2;
            TreeNode root = new TreeNode(nums[mid]);
            root.left = MakeCluster(nums, left, mid - 1);
            root.right = MakeCluster(nums, mid + 1, right);
            return root;
        }

        private static TreeNode SortedArrayToBST(int[] nums)
        {
            return MakeCluster(nums, 0, nums.Length - 1);
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { -10, -3, 0, 2, 5 };
            TreeNode root = SortedArrayToBST(nums);
            Console.WriteLine(root.val);
        }
    }
}
