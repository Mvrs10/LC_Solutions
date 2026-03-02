namespace PartitioningIntoMinimumNumberOfDeciBinaryNumbers;

internal class Program
{
    private static int MinPartitions(string n)
    {
        int max = 1;

        foreach(char c in n)
        {
            max = Math.Max(max, c - '0');
        }

        return max;
    }
    static void Main(string[] args)
    {
        string n = " 128021";
        int result = MinPartitions(n);
        Console.WriteLine(result);
    }
}
