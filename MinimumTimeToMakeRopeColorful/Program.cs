namespace MinimumTimeToMakeRopeColorful;

internal class Program
{
    private static int MinCost(string colors, int[] neededTime)
    {
        int sum = 0;
        int n = colors.Length;

        for (int i = 1; i < n; i++)
        {
            int max = 0;

            if (colors[i] == colors[i - 1])
            {
                sum += neededTime[i - 1];
                while (i < n && colors[i] == colors[i - 1])
                {
                    sum += neededTime[i];
                    max = Math.Max(neededTime[i], neededTime[i - 1]);
                    neededTime[i] = max;
                    i++;
                }
            }
            sum -= max;
        }

        return sum;
    }
    static void Main(string[] args)
    {
        string colors1 = "abaac";
        int[] neededTime1 = [1, 2, 3, 4, 5];

        string colors2 = "aaabbbabbbb";
        int[] neededTime2 = [3, 5, 10, 7, 5, 3, 5, 5, 4, 8, 1];

        int result = MinCost(colors1, neededTime1);
        Console.WriteLine(result);

        result = MinCost(colors2, neededTime2);
        Console.WriteLine(result);
    }
}
