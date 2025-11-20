namespace SetIntersectionSizeAtLeastTwo;

internal class Program
{
    private static int IntersectionSizeTwo(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) =>
        {
            if (a[1] == b[1]) return b[0] - a[0];
            else return a[1] - b[1];
        });

        int num1 = -1, num2 = -1;
        int count = 0;

        foreach (int[] interval in intervals)
        {
            int start = interval[0], end = interval[1];

            bool hasNum1 = num1 >= start && num1 <= end;
            bool hasNum2 = num2 >= start && num2 <= end;

            if (hasNum1 && hasNum2) continue;
            else
            {
                if (hasNum1)
                {
                    num2 = num1;
                    count++;
                }
                else
                {
                    num2 = end - 1;
                    count += 2;
                }
                num1 = end;
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        int[][] intervals = [[1, 3], [3, 7], [8, 9]];
        int result = IntersectionSizeTwo(intervals);
        Console.WriteLine(result);
    }
}
