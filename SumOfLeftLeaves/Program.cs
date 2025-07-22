using DataStructures;

namespace SumOfLeftLeaves;

internal class Program
{
    private static int SumOfLeftLeaves(TreeNode root)
    {
        if (root == null)
            return 0;
        int sum = 0;
        if (root.left != null && root.left.left == null && root.left.right == null)
            sum += root.left.val;
        
        sum += SumOfLeftLeaves(root.left);

        sum += SumOfLeftLeaves(root.right);
        return sum;
    }
    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        int result = SumOfLeftLeaves(root);
        Console.WriteLine(result);
    }
}
