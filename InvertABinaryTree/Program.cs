namespace InvertABinaryTree;
using DataStructures;

internal class Program
{
    private static void InvertNodes(TreeNode node)
    {
        if (node.left == null && node.right == null) return;
        TreeNode temp = node.left;
        node.left = node.right;
        node.right = temp;
        InvertNodes(node.left);
        InvertNodes(node.right);
    }
    private static TreeNode InvertTree(TreeNode root)
    {
        InvertNodes(root);
        return root;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
