using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumDepthOfBinaryTree
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
        private static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int count = 1;
            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + count;
        }
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2));
            int result = MaxDepth(root);
            Console.WriteLine(result);
        }
    }
}
