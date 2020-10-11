using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    class _30DaysDay6ReviewLoops
    {
        // https://www.hackerrank.com/challenges/30-review-loop/problem
        /*
         * Objective
        Today we're expanding our knowledge of Strings and combining it with what we've already learned about loops. Check out the Tutorial tab for learning materials and an instructional video!

        Task
        Given a string, S, of length N that is indexed from 0 to N-1, print its even-indexed and odd-indexed characters as 2 space-separated strings on a single line (see the Sample below for more detail).

        Note: 0 is considered to be an even index.

        Input Format

        The first line contains an integer, T (the number of test cases).
        Each line i of the T subsequent lines contain a String, S.

        Constraints
        1 <= T <= 10
        2 <= length of S <= 10000

        Output Format

        For each String Sj (where 0 <= j <= T-1), print Sj's even-indexed characters, followed by a space, followed by Sj's odd-indexed characters.

        Sample Input

        2
        Hacker
        Rank
        Sample Output

        Hce akr
        Rn ak
         * 
         * 
         */

        static void ReviewLoop()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

            // Step 1 read the total strings as an int
            int n = Convert.ToInt32(Console.ReadLine());

            // Step 2 declare string array to assign the # of strings specified by n
            string[] strings = new string[n];

            // Step 3 actually read those strings
            for (int i = 0; i < n; i++)
            {
                strings[i] = Console.ReadLine();
            }

            // Step 4 split each individual word into their char arrays.
            for (int i = 0; i < strings.Length; i++)
            {
                char[] charArray = strings[i].ToCharArray();
                // Step 5 declare strings to hold the even then the odd concatenations of the chars
                var evens = new StringBuilder();
                var odds = new StringBuilder();
                // Step 6 actually build the evens and the odds
                for (int j = 0; j < charArray.Length; j++)
                {
                    if (j == 0 || j % 2 == 0)
                    {
                        evens.Append(charArray[j]);
                    }
                    else if (j % 2 == 1)
                    {
                        odds.Append(charArray[j]);
                    }
                }
                // Step 7 write 'em out. supposed to call .ToString() on sb objects before printing even though just calling evens/odds seems to work without it: https://docs.microsoft.com/en-us/dotnet/standard/base-types/stringbuilder#converting-a-stringbuilder-object-to-a-string
                Console.WriteLine(evens.ToString() + " " + odds.ToString());
            }
        }
    }
}
