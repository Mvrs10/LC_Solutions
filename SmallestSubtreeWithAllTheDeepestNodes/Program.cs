using DataStructures;
namespace SmallestSubtreeWithAllTheDeepestNodes;

internal class Program
{
    private static TreeNode SubtreeWithAllDeepest(TreeNode root)
    {
        int maxDepth = GetMaxDepth(root);
        return GetSmallestNode(root, 1, maxDepth);
    }

    private static int GetMaxDepth(TreeNode node)
    {
        if (node == null) return 0;

        return 1 + Math.Max(GetMaxDepth(node.left), GetMaxDepth(node.right));
    }

    private static TreeNode GetSmallestNode(TreeNode node, int depth, int maxDepth)
    {
        if (node == null) return null;

        if (depth == maxDepth) return node;

        TreeNode left = GetSmallestNode(node.left, depth + 1, maxDepth);
        TreeNode right = GetSmallestNode(node.right, depth + 1, maxDepth);

        if (left != null && right != null) return node;
        return left ?? right;
    }

    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        TreeNode result = SubtreeWithAllDeepest(root);
        Console.WriteLine(result.val);
    }
}
