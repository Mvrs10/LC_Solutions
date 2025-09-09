namespace FruitsIntoBaskets2;

internal class Program
{
    private static int NumbOfUnplacedFruits(int[] fruits, int[] baskets)
    {
        int unplaced = fruits.Length;
        for (int i = 0; i < fruits.Length; i++)
        {
            for (int j = 0; j < baskets.Length; j++)
            {
                if (fruits[i] <= baskets[j])
                {
                    baskets[j] = 0;
                    unplaced--;
                    break;
                }
            }
        }

        return unplaced;
    }
    static void Main(string[] args)
    {
        List<int> results = new List<int>();
        results.Add(NumbOfUnplacedFruits([4, 2, 5], [3, 5, 4]));
        results.Add(NumbOfUnplacedFruits([3, 6, 1], [6, 4, 7]));
        results.Add(NumbOfUnplacedFruits([8, 2, 5], [1, 5, 2]));

        foreach (int x in results)
        {
            Console.WriteLine(x);
        }
    }
}
