namespace HappyNumber;

internal class Program
{
    private static int EvaluateHappyNumber(int n)
    {
        int happyNum = 0;
        while (n > 0)
        {
            int digit = n % 10;
            happyNum += digit * digit;
            n /= 10;
        }
        return happyNum;
    }
    private static bool IsHappy_Floyd(int n)
    {
        int walk = n;
        int run = EvaluateHappyNumber(n);
        while (run != walk)
        {
            walk = EvaluateHappyNumber(walk);
            run = EvaluateHappyNumber(EvaluateHappyNumber(run));
            if (run == 1)
            {
                return true;
            }
        }
        return run == 1;
    }
    private static bool IsHappy(int n)
    {
        HashSet<int> records = new HashSet<int>();
        while (n != 1)
        {
            if (records.Contains(n))
            {
                return false;
            }
            records.Add(n);
            int happySum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                happySum += digit * digit;
                n /= 10;
            }
            n = happySum;
        }
        return true;
    }
    static void Main(string[] args)
    {
        int n = 2;
        bool result = IsHappy(n);
        Console.WriteLine(result);
        int nn = 19;
        result = IsHappy_Floyd(nn);
        Console.WriteLine(result);
    }
}
