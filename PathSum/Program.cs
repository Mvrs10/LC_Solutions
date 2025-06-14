using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathSum
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

        private static bool Traverse(TreeNode root, int targetSum, int count)
        {
            if (root == null)
            {
                return false;
            }
            count = count + root.val;
            if (root.left == null && root.right == null)
            {
                return count == targetSum;
            }
            return Traverse(root.left, targetSum, count) || Traverse(root.right, targetSum, count);
        }

        private static bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            return Traverse(root, targetSum, 0);
        }

        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(5);

            root.left = new TreeNode(4);
            root.right = new TreeNode(8);

            root.left.left = new TreeNode(11);

            root.left.left.left = new TreeNode(7);
            root.left.left.right = new TreeNode(2);

            root.right.left = new TreeNode(13);
            root.right.right = new TreeNode(4);

            root.right.right.right = new TreeNode(1);

            /* ------------------------------------ */
            int targetSum = 22;
            bool result = HasPathSum(root, targetSum);
            Console.WriteLine(result);
        }
    }
}
