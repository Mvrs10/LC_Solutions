namespace UglyNumber;

internal class Program
{
    private static bool IsUgly(int n)
    {
        if (n < 1) return false;
        while (n > 1)
        {
            if (n % 2 == 0) n /= 2;
            else if (n % 3 == 0) n /= 3;
            else if (n % 5 == 0) n /= 5;
            else return false;
        }
        return true;
    }
    static void Main(string[] args)
    {
        int a = 0;
        int b = 6;
        int c = 1;
        int d = 14;
        bool[] results = [IsUgly(a), IsUgly(b), IsUgly(c), IsUgly(d)];
        foreach (bool r in results)
        {
            Console.WriteLine(r);
        }
    }
}
