using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameTree
{
    internal class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val=0, TreeNode left=null, TreeNode right=null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        private static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if (p == null || q == null)
            {
                return false;
            }
            if (p.val != q.val)
            {
                return false;
            }
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
        static void Main(string[] args)
        {
            TreeNode p = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            TreeNode q = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            bool result = IsSameTree(p, q);
            Console.WriteLine(result);
        }
    }
}
