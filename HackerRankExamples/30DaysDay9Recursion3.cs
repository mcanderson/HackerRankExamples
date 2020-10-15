using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRankExamples
{
    class _30DaysDay9Recursion3
    {
        // https://www.hackerrank.com/challenges/30-recursion/problem

        /*
         * Objective
            Today, we're learning and practicing an algorithmic concept called Recursion. Check out the Tutorial tab for learning materials and an instructional video!

            Recursive Method for Calculating Factorial
            Task
            Write a factorial function that takes a positive integer, /n as a parameter and prints the result of N! (N factorial).

            Note: If you fail to use recursion or fail to name your recursive function factorial or Factorial, you will get a score of 0.

            Input Format

            A single integer, N (the argument to pass to factorial).

            Constraints
            2 <= N <= 12
            Your submission must contain a recursive function named factorial.

            Output Format
            Print a single integer denoting /n.

            Sample Input
            3
            Sample Output
            6
         * 
         */
        static void facFactorial()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        // Complete the factorial function below.
        static int factorial(int n)
        {
            if (n > 1)
            {
                return n * factorial((n - 1));
            }
            else return 1;
        }
    }
}
