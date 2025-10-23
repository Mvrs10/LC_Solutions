namespace FinalValueOfVariableAfterPerformingOperations;

internal class Program
{
    private static int FinalValueAfterOperations(string[] operations)
    {
        int x = 0;
        foreach (string op in operations)
        {
            if (op.Contains('+'))
            {
                x++;
            }
            else
            {
                x--;
            }
        }
        return x;
    }
    static void Main(string[] args)
    {
        string[] ops = ["--X", "X++", "X++"];
        int result = FinalValueAfterOperations(ops);
        Console.WriteLine(result);
    }
}
