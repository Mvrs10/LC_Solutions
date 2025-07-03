namespace AddDigits;

internal class Program
{
    private static int AddDigitLoop(int num)
    {
        if (num < 10) return num;
        int result = 10;
        do
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            result = sum;
            num = result;
        } while (result / 10 > 0);
        return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
