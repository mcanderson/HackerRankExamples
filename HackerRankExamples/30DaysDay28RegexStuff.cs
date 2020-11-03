using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    // https://www.hackerrank.com/challenges/30-regex-patterns/problem
    // Supposedly about regex, patterns, and intro to DB. No actual DB stuff though. Regex not fully needed 
    // since using contains to include anything @gmail. 
    class _30DaysDay28RegexStuff
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            // Could be pretty much any collection that allows K-V pairs, since email is unique ID. But since we're ordering by value, don't need a sorted one.
            Dictionary<string, string> sortedEmails = new Dictionary<string, string>();

            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];

                string emailID = firstNameEmailID[1];

                // Make sure it matches the gmail pattern to add. Otherwise skip adding and go to the next one. 
                if (emailID.Contains("@gmail"))
                {
                    sortedEmails.Add(emailID, firstName);
                }
                else continue;
            }
            // Sort by the value - the name - before writing. 
            foreach (KeyValuePair<string, string> email in sortedEmails.OrderBy(p => p.Value))
            {
                Console.WriteLine(email.Value);
            }
        }
}
