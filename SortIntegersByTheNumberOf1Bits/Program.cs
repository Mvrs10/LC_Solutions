namespace SortIntegersByTheNumberOf1Bits;

internal class Program
{
    private static int[] SortByBits(int[] arr)
    {
        int CountSetBits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                if ((n & 1) == 1)
                    count++;
                n >>= 1;
            }

            return count;
        }

        List<int>[] sorting = new List<int>[32];

        foreach(int n in arr)
        {
            int setBits = CountSetBits(n);
            if (sorting[setBits] == null)
            {
                sorting[setBits] = new List<int>();
            }
            sorting[setBits].Add(n);
        }

        int[] sorted = new int[arr.Length];
        int idx = 0;
        for (int i = 0; i < sorting.Length; i++)
        {
            if (sorting[i] == null) continue;
            if (sorting[i].Count > 1)
            {
                sorting[i].Sort();
            }
            foreach(int n in sorting[i])
            {
                sorted[idx++] = n;
            }
        }
        
        return sorted;
    }

    private static int[] SortByBits_v2(int[] arr)
    {
        Array.Sort(arr, (x, y) =>
        {
            var bx = int.PopCount(x);
            var by = int.PopCount(y);
            return bx == by ? x - y : bx - by;
        });
        return arr;
    }
    static void Main(string[] args)
    {
        int[] arr = [0, 1, 2, 3, 4, 5, 6, 7, 8];
        int[] result = SortByBits(arr);
        foreach(int n in result)
        {
            Console.Write($"{n}-");
        }

        int[] arr2 = [1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1];
        result = SortByBits_v2(arr2);
        foreach (int n in result)
        {
            Console.Write($"{n}-");
        }
    }
}
