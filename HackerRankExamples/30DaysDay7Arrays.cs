using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    class _30DaysDay7Arrays
    {
        // https://www.hackerrank.com/challenges/30-arrays/problem

        /*
         * Objective
        Today, we're learning about the Array data structure. Check out the Tutorial tab for learning materials and an instructional video!

        Task
        Given an array, A, of N integers, print A's elements in reverse order as a single line of space-separated numbers.

        Input Format

        The first line contains an integer, N (the size of our array).
        The second line contains N space-separated integers describing array A's elements.

        Constraints
        1 <= N <= 1000
        1 <= Ai <= 10000, where Ai is the ith integer in the array.
        Output Format

        Print the elements of array A in reverse order as a single line of space-separated numbers.

        Sample Input

        4
        1 4 3 2
        Sample Output

        2 3 4 1
         * 
         */
        static void arrayBackwards()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;

            // Start at the end and go down until you hit the 0, adding the space when it's output. Write instead of WriteLine so they're on the same line.
            // No requirement that the last one doesn't have a space so just leave it in - if it had a different requirement might've included an if for the final one to skip over adding the space. 
            for (int i = (n - 1); i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
