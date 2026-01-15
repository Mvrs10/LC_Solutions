namespace MaximizeAreaOfSquareHoleInGrid;

internal class Program
{
    private static int MaximizeSquareHoleArea(int n, int m, int[] hBars, int[] vBars)
    {
        Array.Sort(hBars);
        Array.Sort(vBars);

        int maxWidth = GetLongestConsecutiveDistance(vBars);
        int maxHeight = GetLongestConsecutiveDistance(hBars);

        int side = Math.Min(maxHeight + 2, maxWidth + 2);

        return side * side;
    }

    private static int GetLongestConsecutiveDistance(int[] bars)
    {
        int max = 0;
        int count = 0;
        for (int i = 1; i < bars.Length; i++)
        {
            if (bars[i] - bars[i - 1] == 1)
                count++;
            else
            {
                max = Math.Max(max, count);
                count = 0;
            }                
        }

        return Math.Max(max,count);
    }

    static void Main(string[] args)
    {
        int n = 2, m = 3;
        int[] hBars = [2, 3];
        int[] vBars = [2, 4];

        int result = MaximizeSquareHoleArea(n, m, hBars, vBars);
        Console.WriteLine(result);
    }
}
