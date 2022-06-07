using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

/*
 * Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with  places after the decimal.

Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to 10^-4 are acceptable.

Example: arr = [1,1,0,-1,-1]

There are n=5 elements, two positive, two negative and one zero. Their ratios are 2/5 = 0.400000, 2/5=0.4000000  and 1/5=.200000 . Results are printed as:

0.400000
0.400000
0.200000
Function Description

Complete the plusMinus function in the editor below.

plusMinus has the following parameter(s):

int arr[n]: an array of integers
Print
Print the ratios of positive, negative and zero values in the array. Each value should be printed on a separate line with 6 digits after the decimal. The function should not return a value.

Input Format

The first line contains an integer, n, the size of the array.
The second line contains n space-separated integers that describe arr[n].

Constraints
0 < n <= 100
-100 <= arr[i] <= 100

Output Format

Print the following 3 lines, each to 6 decimals:

1. proportion of positive values
2. proportion of negative values
3. proportion of zeros
Sample Input

STDIN           Function
-----           --------
6               arr[] size n = 6
-4 3 -9 0 4 1   arr = [-4, 3, -9, 0, 4, 1]
Sample Output

0.500000
0.333333
0.166667
Explanation

There are  positive numbers,  negative numbers, and  zero in the array.
The proportions of occurrence are positive: , negative:  and zeros: 
 */

namespace InterviewExamples
{
    public class _1WeekPrepDay1PlusMinus
    {
    }

class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            // Need everything to be double to make sure the result is double
            double positiveCount = 0;
            double negativeCount = 0;
            double zeroCount = 0;
            double arrayLength = arr.Count;

            for (int i = 0; i < arr.Count; i++)
            {
                switch (arr[i])
                {
                    case 0:
                        zeroCount++;
                        break;
                    case > 0:
                        positiveCount++;
                        break;
                    case < 0:
                        negativeCount++;
                        break;
                }
            }

            // .toString("N6") makes it format to the 6 decimal digits required
            Console.WriteLine((positiveCount / arrayLength).ToString("N6"));
            Console.WriteLine((negativeCount / arrayLength).ToString("N6"));
            Console.WriteLine((zeroCount / arrayLength).ToString("N6"));
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }

}
