namespace FindTheOriginalTypedString1;

internal class Program
{
    private static int PossibleStringCount(string word)
    {
        int count = 1;
        for (int i = 0; i<word.Length -1; i++)
        {
            while (i < word.Length - 1 && word[i] == word[i + 1])
            {
                count++;
                i++;
            }
        }
        return count;
    }

    private static int PossibleStringCountFreqTable(string word)
    {
        int count = 1;
        int[] freqTable = new int[26];
        int BASE = 97;
        int prev = word[0];
        for (int i = 1; i < word.Length; i++)
        {
            if (prev == word[i])
            {
                freqTable[word[i] - BASE]++;
            }
            prev = word[i];
        }
        foreach (int i in freqTable)
        {
            if (i > 0)
            {
                count += i;
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        string word1 = "ere", word2 = "aabbccdd";        
        int result = PossibleStringCount(word1);
        Console.WriteLine(result);
        result = PossibleStringCount(word2);
        Console.WriteLine(result);
        result = PossibleStringCountFreqTable(word1);
        Console.WriteLine(result);
        result = PossibleStringCountFreqTable(word2);
        Console.WriteLine(result);
    }
}
