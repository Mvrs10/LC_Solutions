namespace FirstBadVersion;

internal class Program
{
    private static bool IsBadVersion(int n)
    {
        return n >= 4;
    }

    private static int FirstBadVersion(int n)
    {
        int first = 1;
        int last = n;
        while (first < last)
        {
            int mid = first + (last - first) / 2;
            if (IsBadVersion(mid)) last = mid;
            else first = mid + 1;
        }
        return first;
    }
    static void Main(string[] args)
    {
        int result = FirstBadVersion(9);
        Console.WriteLine(result);
    }
}
