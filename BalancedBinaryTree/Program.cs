using DataStructures;

namespace BalancedBinaryTree;

internal class Program
{
    private static bool IsBalanced(TreeNode root)
    {
        return GetHeights(root) != -1;
    }

    private static int GetHeights(TreeNode node)
    {
        if (node == null) return 0;

        int leftHeight = GetHeights(node.left);
        if (leftHeight == -1) return -1;

        int rightHeight = GetHeights(node.right);
        if (rightHeight == -1) return -1;

        if (Math.Abs(leftHeight - rightHeight) > 1) return -1;

        return Math.Max(leftHeight, rightHeight) + 1;
    }

    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(3);
        TreeNode node1 = new TreeNode(9);
        root.left = node1;

        TreeNode node2 = new TreeNode(10);
        root.right = node2;

        TreeNode node3 = new TreeNode(1);
        node2.left = node3;

        TreeNode node4 = new TreeNode(7);
        node2.right = node4;

        bool result = IsBalanced(root);

        Console.WriteLine(result);
    }
}
