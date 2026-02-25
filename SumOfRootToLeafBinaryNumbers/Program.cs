using DataStructures;

namespace SumOfRootToLeafBinaryNumbers;

internal class Program
{    
    private static int SumRootToLeaf(TreeNode root)
    {
        int sum = 0;

        TraverseEdge(root, 0, ref sum);

        return sum;
    }

    static void TraverseEdge(TreeNode node, int n, ref int sum)
    {
        if (node == null) return;
        n = (n << 1) | node.val;
        if (node.left == null && node.right == null)
        {
            sum += n;
            return;
        }
        TraverseEdge(node.left, n, ref sum);
        TraverseEdge(node.right, n, ref sum);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
