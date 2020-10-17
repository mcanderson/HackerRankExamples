using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    class _30DaysDay112DArrays
    {
        // This is essentially a duplicate  of the interview prep 2d array DS challenge, except the 2D array has more values (so a couple more hourglasses). 
        // I literally copied and pasted my answer for that one into this one and it passed all the tests...so yup. 

        // https://www.hackerrank.com/challenges/30-2d-arrays/problem
        /*
         * Objective
        Today, we're building on our knowledge of Arrays by adding another dimension. Check out the Tutorial tab for learning materials and an instructional video!

        Context
        Given 6 x 6 a  2D Array, A:

        1 1 1 0 0 0
        0 1 0 0 0 0
        1 1 1 0 0 0
        0 0 0 0 0 0
        0 0 0 0 0 0
        0 0 0 0 0 0
        We define an hourglass in A to be a subset of values with indices falling in this pattern in A's graphical representation:

        a b c
          d
        e f g
        There are 16 hourglasses in A, and an hourglass sum is the sum of an hourglass' values.

        Task
        Calculate the hourglass sum for every hourglass in A, then print the maximum hourglass sum.

        Input Format
        There are 6 lines of input, where each line contains 6 space-separated integers describing 2D Array A; every value inA  will be in the inclusive range of -9 to 9.

        Constraints
        -9 <= A[i][j] <= 9
        0 <= i,j <= 5

        Output Format
        Print the largest (maximum) hourglass sum found in A.

        Sample Input

        1 1 1 0 0 0
        0 1 0 0 0 0
        1 1 1 0 0 0
        0 0 2 4 4 0
        0 0 0 2 0 0
        0 0 1 2 4 0
        Sample Output

        19
         * 
         */
        static void Biggest2DHourglass()
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            Console.WriteLine(result);
        }

        static int hourglassSum(int[][] arr)
        {
            // Make biggest sum smaller than the smallest possible answer, i.e. -9 x 7 = -63
            int biggestSum = -100;
            // tempSum used in each loop and reset before the subsequent one begins
            int tempSum = 0;

            // Because we're summing off the t-shape, we go through array values in loop. 
            // -2 because there's only four in each row/column. 
            for (int i = 0; i < (arr.Length - 2); i++)
            {
                for (int j = 0; j < (arr.Length - 2); j++)
                {
                    // Doesn't work when flipped to i, i+1, i+2 in the first round. Tried with the j+1 first instead. 
                    tempSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    // Check if the sum is greater than the biggest one we've tracked so far.
                    // Replace it if it is. 
                    if (tempSum > biggestSum)
                    {
                        biggestSum = tempSum;
                    }
                    // Reset the temporary sum
                    tempSum = 0;
                }
            }
            // Return the value. 
            return biggestSum;
        }
    }
}
