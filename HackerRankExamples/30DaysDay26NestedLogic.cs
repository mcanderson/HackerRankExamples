using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    // https://www.hackerrank.com/challenges/30-nested-logic/problem
    class _30DaysDay26NestedLogic
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string rawReturnDate = Console.ReadLine();
            string rawDueDate = Console.ReadLine();
            // 0 is day, 1 is month, 2 is year
            string[] parsedReturnDate = rawReturnDate.Split(' ');
            string[] parsedDueDate = rawDueDate.Split(' ');
            int[] returnDate = Array.ConvertAll(parsedReturnDate, s => int.Parse(s));
            int[] dueDate = Array.ConvertAll(parsedDueDate, s => int.Parse(s));

            // If it was a future year, fixed fine of 10000
            if (returnDate[2] > dueDate[2])
            {
                Console.WriteLine("10000");
            }
            // If the book was returned late - 500 * month difference. Make sure it's the same year so we're not charging for early return. 
            else if (returnDate[1] > dueDate[1] && returnDate[2].Equals(dueDate[2]))
            {
                int fine = (returnDate[1] - dueDate[1]) * 500;
                Console.WriteLine(fine);
            }
            // For same month and year, but different day
            else if (returnDate[0] > dueDate[0] && returnDate[1].Equals(dueDate[1]) && returnDate[2].Equals(dueDate[2]))
            {
                int fine = (returnDate[0] - dueDate[0]) * 15;
                Console.WriteLine(fine);
            }
            // Otherwise it was early!
            else Console.WriteLine('0');
        }
    }
}
