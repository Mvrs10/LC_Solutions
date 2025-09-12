namespace AverageSalaryExcludingTheMinAndMaxSalary;

internal class Program
{
    private static double Average(int[] salary)
    {
        int min = salary[0];
        int max = salary[0];
        double sum = 0;
        foreach (int s in salary)
        {
            if (s < min)
                min = s;
            if (s > max)
                max = s;
            sum += s;
        }

        return (sum - min - max) / (salary.Length - 2);
    }

    static void Main(string[] args)
    {
        double result = Average([4000, 3000, 1000, 2000]);
        Console.WriteLine(result);
    }
}
