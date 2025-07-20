using System.Collections.Immutable;
using System.Runtime.Serialization.Json;
using System.Text;

namespace DeleteDuplicateFoldersInSystem;

internal class Program
{
    private class TrieNode
    {
        public Dictionary<string, TrieNode> children = new Dictionary<string, TrieNode>();
        public bool toBeDeleted = false;
    }

    
    private static void Collect(TrieNode node, IList<string> path, IList<IList<string>> result)
    {
        foreach (KeyValuePair<string, TrieNode> kvp in node.children)
        {
            if (!kvp.Value.toBeDeleted)
            {
                path.Add(kvp.Key);
                result.Add(new List<string>(path));
                Collect(kvp.Value, path, result);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
    private static string Filter(TrieNode node, Dictionary<string, int> count)
    {
        if (node.children.Count == 0)
            return "";

        List<string> list = new List<string>();
        foreach (KeyValuePair<string ,TrieNode> kvp in  node.children)
        {
            string childSerial = Filter(kvp.Value, count);
            list.Add(kvp.Key+"("+childSerial+")");
        }

        list.Sort();
        string serial = string.Join("", list);
        if (count[serial] > 1)
            node.toBeDeleted = true;

        return serial;
    }

    private static string Serialize(TrieNode node, Dictionary<string, int> count)
    {
        if (node.children.Count == 0)
            return "";

        List<string> list = new List<string>();
        foreach (KeyValuePair<string, TrieNode> kvp in node.children)
        {
            string childSerial = Serialize(kvp.Value, count);
            list.Add(kvp.Key+"("+childSerial+")");
        }

        list.Sort();
        string serial = string.Join("", list);
        count[serial] = count.GetValueOrDefault(serial, 0) + 1;
        return serial;
    }

    private static IList<IList<string>> DeleteDuplicateFolders(IList<IList<string>> paths)
    {
        // 1. Build Trie
        TrieNode root = new TrieNode();
        foreach (IList<string> path in paths)
        {
            TrieNode current = root;
            foreach (string folder in path)
            {
                if (!current.children.ContainsKey(folder))
                    current.children[folder] = new TrieNode();
                current = current.children[folder];
            }
        }

        // 2. Serialize and count signatures
        Dictionary<string, int> count = new Dictionary<string, int>();
        Serialize(root, count);

        // 3. Filter subfolders with duplicate signature
        Filter(root, count);

        // 4. Collect surviving folders

        IList<string> cleanPath = new List<string>();
        IList<IList<string>> result = new List<IList<string>>();
        Collect(root, cleanPath, result);
        return result;
    }
    static void Main(string[] args)
    {
        IList<IList<string>> paths = [["a"], ["c"], ["d"], ["a", "b"], ["c", "b"], ["d", "a"]];
        IList<IList<string>> result = DeleteDuplicateFolders(paths);
        Console.WriteLine("Hello");
    }
}
