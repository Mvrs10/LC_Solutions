namespace RemoveSubfoldersFromTheFilesystem;

internal class Program
{
    private static IList<string> RemoveSubFolders(string[] folder)
    {
        Array.Sort(folder);

        IList<string> result = new List<string>();
        result.Add(folder[0]);
        string root = folder[0];
        for (int i = 1; i < folder.Length; i++)
        {
            if (!folder[i].StartsWith(root + "/"))
            {
                result.Add(folder[i]);
                root = folder[i];
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        string[] folder1 = ["/a", "/a/b", "/c/d", "/c/d/e", "/c/f"];
        IList<string> result = RemoveSubFolders(folder1);
        foreach (string path in result)
        {
            Console.WriteLine(path);
        }
    }
}
