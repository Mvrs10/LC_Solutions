namespace MinimumOperationsToConvertAllElementsToZero;

internal class Program
{
    private static int MinOperations(int[] nums)
    {
        int ops = 0;
        Stack<int> stack = new Stack<int>();
        stack.Push(0);

        foreach (int num in nums)
        {
            if (num == 0)
            {
                while (stack.Peek() > 0)
                {
                    stack.Pop();
                }
                continue;
            }

            while (stack.Count > 0 && stack.Peek() > num)
            {
                stack.Pop();
            }

            if (stack.Count == 0 || stack.Peek() < num)
            {
                ops++;
                stack.Push(num);
            }
        }
        return ops;
    } 
    static void Main(string[] args)
    {
        int[] nums = [1, 2, 2, 1, 16, 4, 0, 3, 5];
        int result = MinOperations(nums);
        Console.WriteLine(result);
    }
}
