using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    class _30DaysDay3IntroConditionalStates
    // https://www.hackerrank.com/challenges/30-conditional-statements/problem
    /*
     * Task
        Given an integer, n, perform the following conditional actions:

        If n is odd, print Weird
        If n is even and in the inclusive range of 2 to 5, print Not Weird
        If n is even and in the inclusive range of 6 to 20, print Weird
        If n is even and greater than 20, print Not Weird
        Complete the stub code provided in your editor to print whether or not n is weird.

        Input Format

        A single line containing a positive integer, n.

        Constraints
        1 <= n <= 100

        Output Format

        Print Weird if the number is weird; otherwise, print Not Weird.
     * 
     * 
     */
    {
        static void Conditionals()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            // Method to determine weird status
            string weirdStatus = checkWeirdness(N);

            Console.WriteLine(weirdStatus);
        }

        public static string checkWeirdness(int N)
        {
            string weirdValue;

            // First conditional - if it's odd and greater than or equal to 1
            if ((N % 2 > 0) && (N >= 1) && (N <= 100))
            {
                weirdValue = "Weird";
                return weirdValue;
            }
            // Second conditional - if it's even and in the inclusive range of 2 to 5 
            else if ((N % 2 == 0) && (N >= 2 && N <= 5))
            {
                weirdValue = "Not Weird";
                return weirdValue;
            }
            // Third conditional - if it's even and inclusive between 6 and 20
            else if ((N % 2 == 0) && (20 >= N) && (N >= 6))
            {
                weirdValue = "Weird";
                return weirdValue;
            }
            // Fourth conditional - if it's even and greater than 20
            else if ((N % 2 == 0) && (N > 20) && (N <= 100))
            {
                weirdValue = "Not Weird";
                return weirdValue;
            }
            //If we don't hit one of our cases, return null. 
            else return null;
        }
    }
}
