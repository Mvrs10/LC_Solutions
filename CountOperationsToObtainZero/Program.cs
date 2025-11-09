namespace CountOperationsToObtainZero;

internal class Program
{
    private static int CountOperations(int num1, int num2)
    {
        int ops = 0;
        while (num1 > 0 && num2 > 0)
        {
            if (num1 >= num2)
                num1 -= num2;
            else
                num2 -= num1;
            ops++;
        }
        return ops;
    }
    static void Main(string[] args)
    {
        int result = CountOperations(2, 3);
        Console.WriteLine(result);
        result = CountOperations(10, 10);
        Console.WriteLine(result);
    }
}
