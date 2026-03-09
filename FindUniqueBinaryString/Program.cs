namespace FindUniqueBinaryString;

internal class Program
{
    private static string FindDifferentBinaryString(string[] nums)
    {
        int n = nums.Length;
        char[] unique = new char[n];

        for (int i = 0; i < n; i++)
        {
            unique[i] = nums[i][i] == '0' ? '1' : '0';
        }

        return new string(unique);
    }

    static void Main(string[] args)
    {
        string[] nums = ["01", "10"];
        string result = FindDifferentBinaryString(nums);
        Console.WriteLine(result);
    }
}
