using DataStructures;
namespace MaximumProductOfSplittedBinaryTree;

internal class Program
{
    private static long totalSum = 0;
    private static long maxProduct = 0;

    private static int MaxProduct(TreeNode root)
    {
        int MOD = 1_000_000_007;
        
        totalSum = GetTotalSum(root);
        FindMaxProduct(root);

        return (int)(maxProduct % MOD);
    }
    
    private static long GetTotalSum(TreeNode node)
    {
        if (node == null) return 0;

        return node.val + GetTotalSum(node.left) + GetTotalSum(node.right);
    }

    private static long FindMaxProduct(TreeNode node)
    {
        if(node == null) return 0;

        long leftSum = FindMaxProduct(node.left);
        long rightSum = FindMaxProduct(node.right);

        long subTreeSum = node.val + leftSum + rightSum;
        long product = (totalSum - subTreeSum) * subTreeSum;
        maxProduct = Math.Max(maxProduct, product);

        return subTreeSum;
    }


    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(1);
        root.left = new TreeNode(2);
        root.right = new TreeNode(3);
        root.left.left = new TreeNode(4);
        root.left.right = new TreeNode(5);
        root.right.left = new TreeNode(6);

        int result = MaxProduct(root);
        Console.WriteLine(result);
    }
}
