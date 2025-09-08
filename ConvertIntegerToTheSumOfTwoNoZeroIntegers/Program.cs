namespace ConvertIntegerToTheSumOfTwoNoZeroIntegers;

internal class Program
{
    private static bool IsNoZeroInteger(int n)
    {
        while (n > 0)
        {
            if (n % 10 == 0)
                return false;
            n /= 10;
        }
        return true;
    }
    private static int[] GetNoZeroIntegers(int n)
    {
        int i = 1;
        int j = n - i;
        while (!IsNoZeroInteger(i) || !IsNoZeroInteger(j))
        {
            i++;
            j--;
        }

        return [i, j];
    }
    static void Main(string[] args)
    {
        Console.WriteLine(IsNoZeroInteger(590523));
        int[] result = GetNoZeroIntegers(109);
        foreach (int i in result)
        {
            Console.WriteLine(i);
        }
    }
}
