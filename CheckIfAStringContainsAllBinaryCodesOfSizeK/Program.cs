namespace CheckIfAStringContainsAllBinaryCodesOfSizeK;

internal class Program
{
    private static bool HasAllCodes(string s, int k)
    {
        HashSet<string> binaryCodes = new HashSet<string>();
        int all = 1 << k;
        for (int i = 0; i + k <= s.Length; i++)
        {
            string binaryCode = s.Substring(i, k);
            binaryCodes.Add(binaryCode);
            if (binaryCodes.Count == all) return true;
        }

        return false;
    }
    static void Main(string[] args)
    {
        string s = "00110110";
        int k = 2;
        bool result = HasAllCodes(s, k);
        Console.Write(result);
    }
}
