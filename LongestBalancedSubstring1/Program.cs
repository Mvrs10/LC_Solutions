namespace LongestBalancedSubstring1;

internal class Program
{
    private static int LongestBalanced(string s)
    {
        int max = 0;        

        for (int i = 0; i < s.Length; i++)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int j = i; j < s.Length; j++)
            {
                if (!map.ContainsKey(s[j]))
                    map[s[j]] = 0;
                map[s[j]]++;

                int count = map.Values.First();
                bool isBalanced = true;
                foreach (KeyValuePair<char, int> kvp in map)
                {
                    if (kvp.Value != count)
                    {
                        isBalanced = false;
                    }
                }
                if (isBalanced)
                    max = Math.Max(max, j - i + 1);
            }
        }

        return max;
    }
    static void Main(string[] args)
    {
        string[] tests = ["a", "abbac", "zzabccy", "aba", "aaaaaa"];
        foreach (string t in tests)
        {
            int result = LongestBalanced(t);
            Console.WriteLine(result);
        }
    }
}
