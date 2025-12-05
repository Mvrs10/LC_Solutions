using System.Text;

namespace IntegerToRoman;

internal class Program
{
    private static string IntToRoman(int num)
    {
        List<KeyValuePair<int, string>> map = new List<KeyValuePair<int, string>>() {
            new KeyValuePair<int,string>(1000, "M"),
            new KeyValuePair<int,string>(900, "CM"),
            new KeyValuePair<int,string>(500, "D"),
            new KeyValuePair<int,string>(400, "CD"),
            new KeyValuePair<int,string>(100, "C"),
            new KeyValuePair<int,string>(90, "XC"),
            new KeyValuePair<int,string>(50, "L"),
            new KeyValuePair<int,string>(40, "XL"),
            new KeyValuePair<int,string>(10, "X"),
            new KeyValuePair<int,string>(9, "IX"),
            new KeyValuePair<int,string>(5, "V"),
            new KeyValuePair<int,string>(4, "IV"),
            new KeyValuePair<int,string>(1, "I"),
        };

        StringBuilder roman = new StringBuilder();
        for (int i = 0; i < map.Count && num > 0; i++)
        {
            while (num >= map[i].Key)
            {
                num -= map[i].Key;
                roman.Append(map[i].Value);
            }
        }

        return roman.ToString();
    }

    private static string IntToRoman_v2(int num)
    {
        string[] ones = ["", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"];
        string[] tens = ["", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"];
        string[] hrns = ["", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"];
        string[] ths = ["", "M", "MM", "MMM"];

        return ths[num / 1000] + hrns[(num % 1000) / 100] + tens[(num % 100) / 10] + ones[num % 10];
    }
    static void Main(string[] args)
    {
        int[] testCases = [3749, 58, 1994, 3999, 944];
        foreach (int test in testCases)
        {
            string result1 = IntToRoman(test);
            string result2 = IntToRoman_v2(test);
            Console.WriteLine(result1 + Environment.NewLine + result2);

        }
    }
}
