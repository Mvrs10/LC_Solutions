using System.Reflection;

namespace IsSubsequence;

internal class Program
{
    private static bool IsSubsequence(string s, string t)
    {
        if (s.Length > t.Length) return false;
        int j = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (j == t.Length) return false;
            while (j < t.Length)
            {
                if (j == t.Length - 1 && s[i] != t[j]) 
                    return false;
                if (s[i] == t[j])
                {
                    j++;
                    break;
                }
                j++;
            }            
        }
        return true;
    }

    static void Main(string[] args)
    {
        string s = "aaa";
        string t = "baa";
        bool result = IsSubsequence(s, t);
        Console.WriteLine(result);
    }
}
