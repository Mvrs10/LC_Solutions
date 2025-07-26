namespace BinaryWatch;

internal class Program
{
    private static int CountBits(int x)
    {
        int count = 0;
        while (x > 0)
        {
            count += x & 1;
            x >>= 1;
        }
        return count;
    }

    private static IList<string> ReadBinaryWatch(int turnedOn)
    {
        IList<string> result = new List<string>();

        for (int h = 0; h < 12; h++)
        {
            for (int m = 0; m < 60; m++)
            {
                if (CountBits(h) + CountBits(m) == turnedOn)
                    result.Add($"{h}:{m:D2}");
            }
        }
        return result;
    }
    static void Main(string[] args)
    {
        IList<string> result = ReadBinaryWatch(1);
        foreach (string time in result)
        {
            Console.WriteLine(time);
        }
    }
}
