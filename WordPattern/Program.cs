using System.Runtime.CompilerServices;

namespace WordPattern;

internal class Program
{
    private static bool WordPattern(string pattern, string s)
    {
        string[] ss = s.Split(' ');
        if (ss.Length != pattern.Length) return false;
        Dictionary<char,string> ps = new Dictionary<char,string>();
        Dictionary<string,char> sp = new Dictionary<string,char>();

        for (int i = 0; i < pattern.Length; i++)
        {
            if(!ps.ContainsKey(pattern[i]))
            {
                ps[pattern[i]] = ss[i];
            }
            else
            {
                if (ps[pattern[i]] != ss[i]) return false;
            }
            if (!sp.ContainsKey(ss[i]))
            {
                sp[ss[i]] = pattern[i];
            }
            else
            {
                if (sp[ss[i]] != pattern[i]) return false;
            }
        }
        return true;
    }

    private static bool WordPattern_v2(string pattern, string s)
    {
        Dictionary<char, string> map = new Dictionary<char, string>();
        string[] ss = s.Split(' ');
        if (pattern.Length != ss.Length) return false;
        for (int i = 0; i < pattern.Length; i++)
        {
            if (map.ContainsKey(pattern[i]))
            {
                if (map[pattern[i]] != ss[i]) return false;
            }
            else
            {
                if (map.ContainsValue(ss[i])) return false;
                map[pattern[i]] = ss[i];
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        string pattern = "abba";
        string s = "dog cat cat dog";
        bool result = WordPattern(pattern, s);
        Console.WriteLine(result);
        result = WordPattern_v2(pattern, s);
        Console.WriteLine(result);
    }
}
