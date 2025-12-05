namespace ContainerWithMostWater;

internal class Program
{
    private static int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int max = 0;

        while (left < right)
        {
            int l = right - left;

            if (height[left] <= height[right])
            {
                max = Math.Max(max, l * height[left]);
                left++;
            }
            else
            {
                max = Math.Max(max, l * height[right]);
                right--;
            }
        }

        return max;
    }
    static void Main(string[] args)
    {
        int[][] testCases = [[1, 8, 6, 2, 5, 4, 8, 3, 7], [1, 1]];
        foreach (int[] testCase in testCases)
        {
            int result = MaxArea(testCase);
            Console.WriteLine(result);
        }
    }
}
