namespace CountCollisionsOnARoad;

internal class Program
{
    private static int CountCollisions(string directions)
    {
        int l = 0;
        int r = directions.Length - 1;
        int collisions = 0;

        while (l <= r && directions[l] == 'L')
        {
            l++;
        }

        while (r >= 0 && directions[r] == 'R')
        {
            r--;
        }

        for (int i = l; i <= r; i++)
        {
            collisions += directions[i] == 'S' ? 0 : 1;
        }

        return collisions;
    }
    static void Main(string[] args)
    {
        string[] directions = ["RLRSLL", "LLRR", "LLSLLRR", "LLRLRLLSLRLLSLSSSS"];
        foreach (string d in directions)
        {
            int result = CountCollisions(d);
            Console.WriteLine(result);
        }
    }
}
