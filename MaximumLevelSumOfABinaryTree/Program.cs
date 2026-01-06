using DataStructures;
namespace MaximumLevelSumOfABinaryTree;

internal class Program
{
    private static int MaxLevelSum(TreeNode root)
    {
        Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();
        queue.Enqueue((root, 1));
        int max = -100_006;
        int sum = 0;
        int current = 1;
        int smallest = 1;

        while (queue.Count > 0)
        {
            (TreeNode node, int level) = queue.Dequeue();

            if (node.left != null) queue.Enqueue((node.left, level + 1));
            if (node.right != null) queue.Enqueue((node.right, level + 1));

            if (level == current)
            {
                sum += node.val;
            }
            else
            {
                if (sum > max)
                {
                    smallest = level - 1;
                    max = sum;
                }

                current = level;
                sum = node.val;
            }
        }

        return sum > max ? current : smallest;
    }

    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(1);
        TreeNode node2 = new TreeNode(7);
        TreeNode node3 = new TreeNode(0);
        root.left = node2;
        root.right = node3;

        TreeNode node4 = new TreeNode(7);
        TreeNode node5 = new TreeNode(1);
        node2.left = node4;
        node2.right = node5;

        int result = MaxLevelSum(root);
        Console.WriteLine(result);
    }
}
