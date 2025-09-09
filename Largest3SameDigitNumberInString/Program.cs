namespace Largest3SameDigitNumberInString;

internal class Program
{
    private static string LargestGoodInteger(string num)
    {
        List<string> GoodInts = new List<string> { "999", "888", "777", "666", "555", "444", "333", "222", "111", "000" };
        foreach (string i in GoodInts)
        {
            if (num.Contains(i))
                return i;
        }
        return "";
    }
    static void Main(string[] args)
    {
        string result = LargestGoodInteger("62227771398222");
        Console.WriteLine(result);
    }
}
