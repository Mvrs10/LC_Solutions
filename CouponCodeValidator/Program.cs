namespace CouponCodeValidator;

internal class Program
{
    private static IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive)
    {
        SortedDictionary<string, List<string>> coupons = new SortedDictionary<string, List<string>>
        {
            {"electronics", new List<string>() },
            {"grocery", new List<string>() },
            {"pharmacy", new List<string>() },
            {"restaurant", new List<string>() },
        };

        static bool isValidCode(string code)
        {
            foreach (char c in code)
            {
                if (!(char.IsLetterOrDigit(c) || c == '_')) return false;
            }
            return code.Length > 0;
        }

        int n = code.Length;
        for (int i = 0; i < n; i++)
        {
            if (isActive[i] == true && coupons.ContainsKey(businessLine[i]) && isValidCode(code[i]))
                coupons[businessLine[i]].Add(code[i]);
        }

        List<string> orderedCoupons = new List<string>();
        foreach (KeyValuePair<string, List<string>> kvp in coupons)
        {
            kvp.Value.Sort(StringComparer.Ordinal);
            orderedCoupons.AddRange(kvp.Value.ToList());
        }

        return orderedCoupons;
    }

    static void Main(string[] args)
    {
        string[] code = ["SAVE20", "", "PHARMA5", "SAVE@20"];
        string[] businessLine = ["restaurant", "grocery", "pharmacy", "restaurant"];
        bool[] isActive = [true, true, true, true];

        IList<string> result = ValidateCoupons(code, businessLine, isActive);
        foreach(string c in result)
        {
            Console.WriteLine(c);
        }
    }
}
