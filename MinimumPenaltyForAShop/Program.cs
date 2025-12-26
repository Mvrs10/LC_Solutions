namespace MinimumPenaltyForAShop;

internal class Program
{
    private static int BestClosingTime(string customers)
    {
        int yes = 0, no = 0;
        int bestClosingTime = 0;

        foreach (char c in customers)
        {
            if (c == 'Y') yes++;
        }

        int penalty = yes;

        for (int i = 0; i <= customers.Length; i++)
        {
            int currentPenalty = yes + no;

            if (currentPenalty < penalty)
            {
                penalty = currentPenalty;
                bestClosingTime = i;
            }

            //if (i == customers.Length) break;

            if (customers[i] == 'Y')
            {
                yes--;
            }                
            else
            {
                no++;
            }                
        }

        return (yes + no < penalty) ? customers.Length : bestClosingTime;
    }
    static void Main(string[] args)
    {
        string customers = "YNYY";
        int result = BestClosingTime(customers);
        Console.WriteLine(result);
    }
}
