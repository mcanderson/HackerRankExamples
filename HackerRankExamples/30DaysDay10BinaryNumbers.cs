using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    class _30DaysDay10BinaryNumbers
    {
        // https://www.hackerrank.com/challenges/30-binary-numbers/problem

        /*
         * Objective
        Today, we're working with binary numbers. Check out the Tutorial tab for learning materials and an instructional video!

        Task
        Given a base-10 integer, n, convert it to binary (base-2). Then find and print the base-10 integer denoting the maximum number of consecutive 1's in n's binary representation.

        Input Format

        A single integer, n.

        Constraints
        1 <= n <= 10^6

        Output Format

        Print a single base-10 integer denoting the maximum number of consecutive 1's in the binary representation of n.

        Sample Input 1
        5
        Sample Output 1
        1

        Sample Input 2
        13
        Sample Output 2
        2

        Explanation
        Sample Case 1:
        The binary representation of 5 is 101, so the maximum number of consecutive 1's is 1.

        Sample Case 2:
        The binary representation of 13 is 1101, so the maximum number of consecutive 1's is 2.
         * 
         * 
         */
        static void binaryNums()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int consecInts = getConsecutiveOnes(n);
            Console.WriteLine(consecInts);
        }

        public static int getConsecutiveOnes(int n)
        {
            // Convert the base 10 int to binary
            string binaryNum = Convert.ToString(n, 2);
            // return longest to main method
            int longest = 0;
            // use for the current chain of consecutive 1's
            int currentString = 0;

            // iterate through the string of binary #s
            for (int i = 0; i < binaryNum.Length; i++)
            {
                // Since we're technically grabbing a char from the binary string, convert to number to compare and increment current chain by 1 if it's a 1
                if (Char.GetNumericValue(binaryNum[i]) == 1)
                {
                    currentString++;
                    // Now check if our current count is higher than the last highest and assign if it is.
                    if (currentString > longest)
                    {
                        longest = currentString;
                    }
                }
                // If the chain is interrupted, reset the counter. 
                else
                {
                    currentString = 0;
                    continue;
                }
            }
            // Return the count for the longest chain. 
            return longest;
        }
    }
}
