using DataStructures;
namespace BalanceABinarySearchTree;

internal class Program
{
    private static TreeNode BalanceBST(TreeNode root)
    {
        List<TreeNode> nodes = new List<TreeNode>();
        InorderSort(root, nodes);
        TreeNode newRoot = BuildBalanceBST(nodes, 0, nodes.Count - 1);

        return newRoot;
    }

    private static void InorderSort(TreeNode node, List<TreeNode> nodes)
    {
        if (node == null) return;

        InorderSort(node.left, nodes);
        nodes.Add(node);
        InorderSort(node.right, nodes);
    }

    private static TreeNode BuildBalanceBST(List<TreeNode> nodes, int low, int high)
    {
        if (low > high) return null;

        int mid = low + (high - low) / 2;
        TreeNode node = nodes[mid];

        node.left = BuildBalanceBST(nodes, low, mid - 1);
        node.right = BuildBalanceBST(nodes, mid + 1, high);

        return node;
    }

    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(1);
        root.right = new TreeNode(2);
        root.right.right = new TreeNode(3);
        root.right.right.right = new TreeNode(4);

        TreeNode result = BalanceBST(root);

        Console.WriteLine(result.val);
    }
}
