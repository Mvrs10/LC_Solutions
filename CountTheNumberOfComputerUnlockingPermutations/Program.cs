namespace CountTheNumberOfComputerUnlockingPermutations;

internal class Program
{
    private static int CountPermutations(int[] complexity)
    {
        long permutation = 1;

        for (int i = 1; i < complexity.Length; i++)
        {
            if (complexity[i] <= complexity[0])
                return 0;

            permutation = (permutation * i) % 1_000_000_007;
        }

        return (int)permutation;
    }

    static void Main(string[] args)
    {
        int[] complexity = [4, 6, 6, 6, 6, 6, 6, 6, 6, 6];
        int result = CountPermutations(complexity);
        Console.WriteLine(result);
    }
}
