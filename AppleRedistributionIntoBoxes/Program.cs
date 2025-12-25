namespace AppleRedistributionIntoBoxes;

internal class Program
{
    private static int MinimumBoxes(int[] apple, int[] capacity)
    {
        Array.Sort(capacity, (a, b) => b - a);

        int n = apple.Length, m = capacity.Length;
        int i = 0, j = 0;
        int boxes = 1; 

        while (i < n && j < m)
        {
            capacity[j] -= apple[i];

            if (capacity[j] >= 0)
            {
                i++;
            }
            else
            {
                apple[i] = -capacity[j];
                j++;
                boxes++;
            }
        }

        return boxes;
    }
    static void Main(string[] args)
    {
        int[] apple = [5,5,5];
        int[] capacity = [2,4,2,7];

        int result = MinimumBoxes(apple, capacity);
        Console.WriteLine(result);
    }
}
