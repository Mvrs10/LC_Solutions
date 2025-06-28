namespace CountCompleteTreeNodes;
using DataStructures;

internal class Program
{
    static int CountNodes(TreeNode root)
    {
        if (root == null) return 0;
        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }
    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2));
        int result = CountNodes(root);
        Console.Write(result);
    }
}
