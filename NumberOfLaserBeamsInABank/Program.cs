namespace NumberOfLaserBeamsInABank;

internal class Program
{
    private static int NumberOfBeams(string[] bank)
    {
        int beams = 0;
        int[] devices = new int[bank.Length];

        for (int i = 0; i < bank.Length; i++)
        {
            int count = 0;
            foreach (char cell in bank[i])
            {
                if (cell == '1')
                    count++;
            }
            devices[i] = count;
        }

        int cur = 0;
        foreach (int d in devices)
        {
            if (d != 0)
            {
                if (cur != 0)
                {
                    beams += d * cur;
                }
                cur = d;
            }
        }

        return beams;
    }
    static void Main(string[] args)
    {
        string[] bank = ["011001", "000000", "010100", "001000"];
        int result = NumberOfBeams(bank);
        Console.WriteLine(result);
    }
}
