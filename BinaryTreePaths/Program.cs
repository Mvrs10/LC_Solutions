using DataStructures;
using System.Text;

namespace BinaryTreePaths;

internal class Program
{
    private static void BinaryTreePath(TreeNode root, IList<string> list, string path)
    {
        if (root.left == null && root.right == null)
        {
            list.Add(path + root.val);
            return;
        }
        if (root.left != null)
            BinaryTreePath(root.left, list, path + root.val + "->");
        if (root.right != null)
            BinaryTreePath(root.right, list, path + root.val + "->");
    }
    private static IList<string> BinaryTreePath(TreeNode root)
    {
        IList<string> result = new List<string>();
        BinaryTreePath(root, result, String.Empty);
        return result;
    }
    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(1, new TreeNode(2, null, new TreeNode(5)), new TreeNode(3));
        IList<string> result = BinaryTreePath(root);
        foreach (string s in result)
        {
            Console.WriteLine(s);
        }
    }
}
