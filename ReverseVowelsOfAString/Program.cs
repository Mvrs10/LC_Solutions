namespace ReverseVowelsOfAString;

internal class Program
{    
    private static bool IsVowel(char c)
    {
        char[] VOWELS = ['a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'];
        return VOWELS.Contains(c);
    }

    private static string ReverseVowels(string s)
    {
        char[] cs = s.ToCharArray();
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (IsVowel(s[left]))
            {                
                while (!IsVowel(s[right])) right--;
                cs[left] = s[right];
                cs[right--] = s[left];
            }
            left++;
        }
        return new string(cs);
    }

    private static string ReverseVowels_v2(string s)
    {
        char[] cs = s.ToCharArray();
        List<int> vIndices = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (IsVowel(s[i])) vIndices.Add(i);
        }
        if (vIndices.Count == 0) return s;

        for (int i = 0; i <= vIndices.Count / 2; i++)
        {
            cs[vIndices[i]] = s[vIndices[vIndices.Count - 1 - i]];
            cs[vIndices[vIndices.Count - 1 - i]] = s[vIndices[i]];
        }
        return new string(cs);
    }
        static void Main(string[] args)
    {
        string s1 = "IceCreAm";
        string result = ReverseVowels(s1);
        Console.WriteLine(result);

        result = ReverseVowels_v2(s1);
        Console.WriteLine(result);

        string s2= " ";
        result = ReverseVowels_v2(s2);
        Console.WriteLine(result);
    }
}
