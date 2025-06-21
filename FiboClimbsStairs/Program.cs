using System;

namespace FiboClimbsStairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibo climbs the stairs");
            int result;
            result = ClimbStairs(1);
            result = ClimbStairs(2);
            result = ClimbStairs(45);
            Console.WriteLine(result);
        }
        private static int ClimbStairs(int n)
        {
            int waysForFirstStair = 1; int waysForSecondStair = 2;
            int distinctWays = 0;
            if (n<3)
            {
                return n;
            }
            while (n >= 3)
            {
                distinctWays = waysForFirstStair + waysForSecondStair;
                waysForFirstStair = waysForSecondStair;
                waysForSecondStair = distinctWays;
                n--;
            }
            return distinctWays;
        } 
    }
}
