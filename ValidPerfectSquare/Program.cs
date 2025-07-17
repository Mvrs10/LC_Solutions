namespace ValidPerfectSquare;

internal class Program
{
    private static bool IsPerfectSquare(int num)
    {
        if (num < 2) return true;
        int front = 0;
        int back = num / 2;

        while (front <= back)
        {
            long mid = (front + back) / 2;
            long square = mid * mid;
            if (square == num) return true;
            if (square > num) back = (int)mid - 1;
            else
                front = (int)mid + 1;
        }
        return false;
    }
    static void Main(string[] args)
    {
        bool result = IsPerfectSquare(100);
        Console.WriteLine(result);
        result = IsPerfectSquare(808201);
        Console.WriteLine(result);
    }
}
