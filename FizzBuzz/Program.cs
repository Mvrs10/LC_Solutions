namespace FizzBuzz;

internal class Program
{
    private static IList<string> FizzBuzz(int n)
    {
        IList<string> result = new List<string>(n);

        for (int i = 1; i <= n; i++)
        {
            if (i % 15 == 0)
                result.Add("FizzBuzz");
            else if (i % 5 == 0)
                result.Add("Buzz");
            else if (i % 3 == 0)
                result.Add("Fizz");
            else
                result.Add(i.ToString());
        }

        return result;
    }

    private static IList<string> FizzBuzz2(int n)
    {
        List<string> output = new List<string>(n);

        for (int i = 0; i < n; i++)
        {
            int num = i + 1;

            switch (num)
            {
                case int j when j % 15 == 0:
                    output.Add("FizzBuzz");
                    break;
                case int j when j % 5 == 0:
                    output.Add("Buzz");
                    break;
                case int j when j % 3 == 0:
                    output.Add("Fizz");
                    break;
                default:
                    output.Add(num + "");
                    break;
            }
        }

        return output;
    }
    static void Main(string[] args)
    {
        IList<string> fb = FizzBuzz(15);
        foreach (string s in fb)
        {
            Console.WriteLine(s);
        }

        fb = FizzBuzz2(10);
        foreach (string s in fb)
        {
            Console.WriteLine(s);
        }
    }
}
