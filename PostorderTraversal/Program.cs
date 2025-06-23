using System;
using System.Collections.Generic;

namespace PostorderTraversal
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
    internal class Program
    {
        private static void TraversePostorderly(TreeNode node, IList<int> list)
        {
            if (node == null)
            {
                return;
            }
            TraversePostorderly(node.left, list);
            TraversePostorderly(node.right, list);
            list.Add(node.val);
        }

        private static IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            TraversePostorderly(root, result);
            return result;
        }

        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);

            root.left = new TreeNode(2);
            root.right = new TreeNode(3);

            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);

            root.right.right = new TreeNode(8);

            root.left.right.left = new TreeNode(6);
            root.left.right.right = new TreeNode(7);

            root.right.right.left = new TreeNode(9);

            IList<int> result = PostorderTraversal(root);

            foreach(int x in result)
            {
                Console.Write(x + " ");
            }
        }
    }
}
