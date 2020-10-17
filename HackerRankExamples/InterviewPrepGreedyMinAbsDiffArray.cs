using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRankExamples
{
    class InterviewPrepGreedyMinAbsDiffArray
    {
        // Wasn't greedy enough on the first try - failed two tests because it wasn't fast enough. 
        // This was the second go round
        // https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=greedy-algorithms

        /*
         * Consider an array of integers, arr = [arr[0], arr[1],...arr[n-1]]. We define the absolute difference between two elements, a[i] and a[j] (where i != j), to be the absolute value of a[i] - a[j].

        Given an array of integers, find and print the minimum absolute difference between any two elements in the array. 
        For example, given the array arr = [-2,2,4] we can create 3 pairs of numbers: [-2,2], [-2,4] and [2,4]. 
        The absolute differences for these pairs are |(-2)-2| = 4, |(-2)-4| = 6, and |2-4| = 2. The minimum absolute difference is 2.

        Function Description

        Complete the minimumAbsoluteDifference function in the editor below. It should return an integer that represents the minimum absolute difference between any pair of elements.

        minimumAbsoluteDifference has the following parameter(s):

        n: an integer that represents the length of arr
        arr: an array of integers
        Input Format

        The first line contains a single integer n, the size of arr.
        The second line contains n space-separated integers arr[i].

        Constraints
        2 <= n <= 10^5
        -10^9 <= arr[i] <= 10^9

        Output Format

        Print the minimum absolute difference between any two elements in the array.

        Sample Input 0
        3
        3 -7 0

        Sample Output 0
        3
         * 
         */

        static void greedyDiff()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = minimumAbsoluteDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        // Complete the minimumAbsoluteDifference function below.
        static int minimumAbsoluteDifference(int[] arr)
        {
            // Return value - initialize to the biggest number 10^9, unlikely to hit this..
            int minAbs = 1000000000;
            int tempDifference = 0;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                tempDifference = Math.Abs(arr[i] - arr[i + 1]);
                if (tempDifference < minAbs)
                {
                    minAbs = tempDifference;
                }
            }
            return minAbs;
        }
    }
}
