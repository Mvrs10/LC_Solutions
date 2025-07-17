namespace GuessNumberHigherOrLower;

internal class Program
{
    private static int Guess(int number)
    {
        const int PICK = 6;
        if (number == PICK) return 0;
        else if (number > PICK) return -1;
        else return 1;
    }

    private static int GuessNumber(int n)
    {
        int left = 1;
        int right = n;

        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            n = Guess(mid);
            switch (n)
            {
                case -1:
                    right = mid - 1;
                    break;
                case 1:
                    left = mid + 1;
                    break;
                case 0:
                    return mid;
            }
        }
        return n;
    }
    static void Main(string[] args)
    {
        int result = GuessNumber(10);
        Console.WriteLine(result);
    }
}
