namespace ReverseInteger;

internal class Program
{
    private static int Reverse(int x)
    {
        if (x > 2147483641 || x < -2147483641)
            return 0;

        int temp = x >= 0 ? x : -x;
        List<int> digits = new List<int>();

        while (temp > 0)
        {
            digits.Add(temp % 10);
            temp /= 10;
        }

        int reverse = 0;
        int n = digits.Count;
        if (n < 10 || digits[0] < 2)
        {
            for (int i = 0; i < n; i++)
            {
                reverse = reverse * 10 + digits[i];
            }
        }

        else
        {
            int[] maxInt = [2, 1, 4, 7, 4, 8, 3, 6, 4, 8];
            bool areEqual = true;
            for (int i = 0; i < n; i++)
            {
                if (digits[i] > maxInt[i] && areEqual)
                    return 0;

                reverse = reverse * 10 + digits[i];
                areEqual = digits[i] == maxInt[i];
            }
        }

        return x < 0 ? -reverse : reverse;
    }

    static void Main(string[] args)
    {
        int[] testCases = [2147483642, -2147483642, 2147483622, -2147483632, 2147483641, 1563847412, -2147483412];
        foreach (int test in testCases)
        {
            int result = Reverse(test);
            Console.WriteLine(result);
        }
    }
}
