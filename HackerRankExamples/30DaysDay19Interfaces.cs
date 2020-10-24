using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    // https://www.hackerrank.com/challenges/30-interfaces/problem
    // Renamed Calculator to CalculatorI because of another day that already used calculator, and like usually, Solution renamed to this day's class.
    class _30DaysDay19Interfaces
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new CalculatorI();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }

    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    public class CalculatorI : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sum = 0;
            // Go backwards until 1. Could potentially add answer for n / i to make more efficient - so do n % i and then do n / i to add both the 
            // divisor and it's pair, and then figure out where to stop early instead of incrementing through all of n. Decided to leave like this though -
            // test cases didn't require this to be quicker and this passed. 
            for (int i = n; i > 0; i--)
            {
                // Check if n is divisible by this #
                if (n % i == 0)
                {
                    // If it is, include in sum.
                    sum += i;
                }
                else continue;
            }

            return sum;
        }
    }
}
