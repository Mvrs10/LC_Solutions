namespace IsomorphicStrings;
internal class Program
{
    private static bool IsIsomorphicCheck(string s, string t)
    {
        if (s.Length != t.Length) return false;
        Dictionary<char,char> map = new Dictionary<char,char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!map.ContainsKey(s[i]))
            {
                map.Add(s[i], t[i]);
            }
            else
            {
                if (map[s[i]] != t[i])
                {
                    return false;
                }
            }
        }
        return true;
    }
    private static bool IsIsomorphic(string s, string t)
    {
        return IsIsomorphicCheck(s, t) && IsIsomorphicCheck(t, s);
    }
    private static bool IsIsomorphicCheckv2(string s, string t)
    {
        if (s.Length != t.Length) return false;
        Dictionary<char, char> mapST = new Dictionary<char, char>();
        Dictionary<char, char> mapTS = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (mapST.TryGetValue(s[i], out char svalue) && svalue != t[i]) return false;
            else mapST[s[i]] = t[i];

            if (mapTS.TryGetValue(t[i], out char tvalue) && tvalue != s[i]) return false;
            else mapTS[t[i]] = s[i];
        }
        return true;
    }
    static void Main(string[] args)
    {
        string s1 = "title";
        string t1 = "paper";
        bool result = IsIsomorphic(s1, t1);
        Console.WriteLine(result);
        string s2 = "foo";
        string t2 = "bar";
        result = IsIsomorphicCheckv2(s2, t2);
        Console.WriteLine(result);
        string s3 = "badc";
        string t3 = "baba";
        result = IsIsomorphicCheckv2(s3,t3);
        Console.WriteLine(result);
    }
}
