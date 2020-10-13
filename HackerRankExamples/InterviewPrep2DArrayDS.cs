using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRankExamples
{
    class InterviewPrep2DArrayDS
    {
        // https://www.hackerrank.com/challenges/2d-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        /*
         * Given a 6 x 6 2D Array, arr:

            1 1 1 0 0 0
            0 1 0 0 0 0
            1 1 1 0 0 0
            0 0 0 0 0 0
            0 0 0 0 0 0
            0 0 0 0 0 0
            An hourglass in A is a subset of values with indices falling in this pattern in arr's graphical representation:

            a b c
              d
            e f g
            There are 16 hourglasses in arr. An hourglass sum is the sum of an hourglass' values. Calculate the hourglass sum for every hourglass in arr, then print the maximum hourglass sum. The array will always be 6 x 6.

            Example


            -9 -9 -9  1 1 1 
             0 -9  0  4 3 2
            -9 -9 -9  1 2 3
             0  0  8  6 6 0
             0  0  0 -2 0 0
             0  0  1  2 4 0
            The 16 hourglass sums are:

            -63, -34, -9, 12, 
            -10,   0, 28, 23, 
            -27, -11, -2, 10, 
              9,  17, 25, 18
            The highest hourglass sum is 28 from the hourglass beginning at row 1, column 2:

            0 4 3
              1
            8 6 6
            Note: If you have already solved the Java domain's Java 2D Array challenge, you may wish to skip this challenge.

            Function Description

            Complete the function hourglassSum in the editor below.

            hourglassSum has the following parameter(s):

            int arr[6][6]: an array of integers
            Returns

            int: the maximum hourglass sum
            Input Format

            Each of the 6 lines of inputs arr[i] contains 6 space-separated integers arr[i][j].

            Constraints
        -9 <= arr[i][j] <= 9
        0 <= i, j <= 5

            Output Format

            Print the largest (maximum) hourglass sum found in arr.

            Sample Input

            1 1 1 0 0 0
            0 1 0 0 0 0
            1 1 1 0 0 0
            0 0 2 4 4 0
            0 0 0 2 0 0
            0 0 1 2 4 0
            Sample Output

            19
         */
        static void ArrayStuff()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        // Complete the hourglassSum function below.
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
