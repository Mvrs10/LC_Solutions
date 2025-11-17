namespace CheckIfAll1sAreAtLeastLengthKPlacesAway;

internal class Program
{
    private static bool KLengthApart(int[] nums, int k)
    {
        int n = nums.Length;
        int i = 0;
        int current = -1;

        while (i < n)
        {
            if (nums[i] == 1)
            {
                if (current != -1)
                {
                    int distance = i - current - 1;
                    if (distance < k)
                        return false;
                }
                current = i;
            }
            i++;
        }
        return true;
    }

    private static bool KLengthApart_v2(int[] nums, int k)
    {
        List<int> pos = new List<int>();        

        for (int i = 0; i < nums.Length; i++)
        {            
            if (nums[i] == 1)
            {                
                pos.Add(i);
                int n = pos.Count;
                if (n > 1)
                {
                    int distance = pos[n - 1] - pos[n - 2] - 1;
                    if (distance < k)
                        return false;
                }
            }
        }

        return true;
    }
    static void Main(string[] args)
    {
        int[] nums = [1, 0, 0, 0, 1, 0, 0, 1];
        bool result = KLengthApart(nums, 2);
        Console.WriteLine(result);
        nums = [1, 0, 1];
        result = KLengthApart_v2(nums, 2);
        Console.WriteLine(result);
    }
}
