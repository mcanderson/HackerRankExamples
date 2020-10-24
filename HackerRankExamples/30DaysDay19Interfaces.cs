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
            int tempMiddle = 0;
            int secondDivisor = 0;
            for (int i = n; i > 0; i--)
            {
                // Check if n is divisible by this #. If it isn't, continue.
                if (n % i == 0)
                {
                    secondDivisor = n / i;
                    if (secondDivisor >= tempMiddle && secondDivisor < i)
                    {
                        tempMiddle = secondDivisor;
                        // Add both parts of divisor
                        sum += secondDivisor + i;
                    }
                    // If not true, double-check if it's 1. Add to sum. 
                    else if (secondDivisor == i)
                    {
                        sum += i;
                    }
                    // Short cut out if we're starting to hit the other divisors we already added to some - have to do this so we stop going through the for. 
                    else return sum;
                }
                else continue;
            }

            return sum;
        }
    }
}
