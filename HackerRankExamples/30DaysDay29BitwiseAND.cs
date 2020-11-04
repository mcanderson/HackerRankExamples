using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    // https://www.hackerrank.com/challenges/30-bitwise-and/problem
    class _30DaysDay29BitwiseAND
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                // Maximum number in the set?
                int n = Convert.ToInt32(nk[0]);
                // The integer the maximum possible value of A&B (from set) can be
                int k = Convert.ToInt32(nk[1]);

                // Honestly don't really understand how this works. 
                // Credit for code here - https://www.hackerrank.com/challenges/30-bitwise-and/forum/comments/388648
                // Credit for possible explanation to - https://www.hackerrank.com/challenges/30-bitwise-and/forum/comments/351312
                /*
                 * The idea is to check whether the highest number less than k that is, k - 1 when converted to bits ends with a 0 or 1.
                 If k - 1 ends with 0 if you add 1 to k - 1 (that is k). The last digit turns to 1 (eg. 2 (10) + 1(01) = 3 (11)). Since, k <= N. Since K and K - 1 are different only by 1 digit when converted to bits, K & K - 1 would always be K - 1.
                 If k - 1 ends with 1 (eg 3 - 11 ) check if k | k - 1 is less than or equal to N ( 4 | 3 -- 100 | 011 -> 111). This is because K and K - 1 only differ by one and '|' operation would turn the least significant zero to one. If this number is than or equal to N then the answer once again would be K - 1.
                 Otherwise, k - 2 as it ends in a zero.
                 */
                if (((k - 1) | k) > n && k % 2 == 0)
                    Console.WriteLine(k - 2);
                else
                    Console.WriteLine(k - 1);
            }
        }
    }
}
