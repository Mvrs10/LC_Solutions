using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InorderTraversal
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

        private static void Traverse(TreeNode node, List<int> result)
        {
            if (node == null)
            {
                return;
            }
            Traverse(node.left, result);
            result.Add(node.val);
            Traverse(node.right, result);
        }

        private static IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            Traverse(root, result);
            return result;
        }

        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1,
    new TreeNode(2,
        new TreeNode(4),
        new TreeNode(5,
            new TreeNode(6),
            new TreeNode(7)
        )
    ),
    new TreeNode(3,
        null,
        new TreeNode(8,
            new TreeNode(9),
            null
        )
      )
);
            IList<int> result = InorderTraversal(root);
            Debug.WriteLine(result);
        }
    }
}
