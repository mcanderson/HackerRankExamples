using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    // https://www.hackerrank.com/challenges/30-running-time-and-complexity/problem
    class _30DaysDay25TimeComplexity
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int count = Int32.Parse(Console.ReadLine());
            int[] numbers = new int[count];
            bool isPrime;
            for (int i = 0; i < count; i++)
            {
                numbers[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                isPrime = FindPrimes(numbers[i]);
                if (isPrime)
                {
                    Console.WriteLine("Prime");
                }
                else Console.WriteLine("Not prime");
            }
        }
        public static bool FindPrimes(int number)
        {
            // 1 isn't prime, so return false if 1
            if (number == 1)
            {
                return false;
            }
            // Used the trial division strategy of checking - https://cp-algorithms.com/algebra/primality_tests.html
            // Should be linear time? = O(n)
            for (int d = 2; d * d <= number; d++)
            {
                if (number % d == 0)
                {
                    return false;
                }
            }
            // Only hits this if it is prime - return true
            return true;
        }
    }
}
