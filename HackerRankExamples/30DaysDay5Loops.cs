using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    class _30DaysDay5Loops
    {
        // https://www.hackerrank.com/challenges/30-loops/problem
        /*
         * Objective
        In this challenge, we're going to use loops to help us do some simple math. Check out the Tutorial tab to learn more.

        Task
        Given an integer, n, print its first 10 multiples. Each multiple n x i (where 1 <= i <= 10) should be printed on a new line in the form: n x i = result.

        Input Format

        A single integer, n.

        Constraints
        2 <= n <= 20

        Output Format

        Print 10 lines of output; each line i (where 1 <= i <= 10) contains the reusult of n x i in the form:
        n x i = result.
         * 
         */
        static void loopLoop()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            // Loop 0 - 9 and add 1 in the loop for the actual calculation
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(n + " x " + (i + 1) + " = " + (n * (i + 1)));
            }
        }
    }
}
