using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    // https://www.hackerrank.com/challenges/30-more-exceptions/problem
    // Essentially just throwing an exception that goes back to the calling method when passed bad parameters. 

    //Write your code here
    class Calculator
    {
        public int power(int number, int power)
        {
            if (number < 0 || power < 0)
            {
                throw new Exception("n and p should be non-negative");
            }
            else
            {
                // Power returns double, so need to cast back to int
                int result = (int)Math.Pow(number, power);
                return result;
            }
        }
    }
    class _30DaysDay17MoreExceptions
    {
        static void Main(String[] args)
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }
        }
    }
}
