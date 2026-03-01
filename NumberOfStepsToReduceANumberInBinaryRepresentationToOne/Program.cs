using System.Diagnostics;
using System.Text;

namespace NumberOfStepsToReduceANumberInBinaryRepresentationToOne;

internal class Program
{
    private static int NumSteps(string s)
    {
        StringBuilder sb = new StringBuilder(s);
        int count = 0;
        while (sb.Length > 1)
        {
            int n = sb.Length;
            if (sb[n - 1] == '1')
            {
                int i = n - 1;
                while (i >= 0)
                {
                    if (sb[i] == '1')
                    {
                        sb[i] = '0';
                        i--;
                    }
                    else
                    {
                        sb[i] = '1';
                        break;
                    }
                }

                if (i < 0) sb.Insert(0, '1');
            }
            else
            {
                sb.Remove(n - 1, 1);
            }
            count++;
        }

        return count;
    }

    static void Main(string[] args)
    {
        string s = "1101";
        int result = NumSteps(s);
        Console.WriteLine(result);
    }
}
