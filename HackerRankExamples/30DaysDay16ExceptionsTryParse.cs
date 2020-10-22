using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    // https://www.hackerrank.com/challenges/30-exceptions-string-to-integer/submissions/code/184929543
    // Made an attempt using TryParse and manually throwing the exception - e.g. throw new Exception() - but even though the output was right 
    // When running the code, it was failing the tests. =/

    /*
     * if (!int.TryParse(S, out number))
                {
                    throw new Exception();
                }
     */
    class _30DaysDay16ExceptionsTryParse
    {
        static void Main(String[] args)
        {
            string S = Console.ReadLine();
            try
            {
                int input = int.Parse(S);
                Console.WriteLine(input);
            }
            catch (Exception e)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}
