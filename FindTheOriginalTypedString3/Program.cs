namespace FindTheOriginalTypedString2
{
    internal class Program
    {
        private static int PossibleStringCount(string word, int k)
        {
            int INT_GUARD = 1_000_000_007;
            List<int> groups = new List<int>(); // Hold the count of each group of same letter.
            int n = word.Length;
            int count = 1;
            for (int i = 1;  i < n; i++)
            {                
                if (word[i] == word[i - 1]) count++;
                else
                {
                    groups.Add(count);
                    count = 1;
                }
            }
            groups.Add(count); // Last group

            long totalCombination = 1; // Total possible outcomes.
            foreach (int v in groups)
            {
                totalCombination = (totalCombination * v) % INT_GUARD;
            }

            if (groups.Count >= k) return (int)totalCombination; // Alice must type each group of letter once!

            long[] dp = new long[k];
            dp[0] = 1;

            foreach (int g in groups)
            {
                long[] tempDp = new long[k];
                long[] prefix = new long[k + 1];
                for (int i = 0; i < k; i++)
                {
                    prefix[i + 1] = (prefix[i] + dp[i]) % INT_GUARD;
                }
                for (int j = 0; j < k; j++)
                {
                    int minS = Math.Max(0, j - g);
                    tempDp[j] = (prefix[j] - prefix[minS] + INT_GUARD) % INT_GUARD;
                }
                dp = tempDp;
            }

            long invalid = 0;
            for (int i = 0; i < k; i++)
            {
                invalid = (invalid + dp[i]) % INT_GUARD;
            }

            return (int)(totalCombination - invalid + INT_GUARD) % INT_GUARD;
        }
        static void Main(string[] args)
        {
            string word1 = "aabbccdd";
            string word2 = "aaabbb";
            int result = PossibleStringCount(word1, 7);
            Console.WriteLine(result);
            result = PossibleStringCount(word2, 3);
            Console.WriteLine(result);
        }
    }
}
