namespace NimGame;

internal class Program
{
    private static bool CanWinNim(int n)
    {
        return n % 4 != 0;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(CanWinNim(5));
    }
}
