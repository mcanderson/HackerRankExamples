using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    class _30DaysDay14Scope
    // https://www.hackerrank.com/challenges/30-scope/problem
    // Too lazy to copy whole description
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }

    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] list)
        {
            elements = list;
        }
        // Add your code here
        public void computeDifference()
        {
            // Since we're getting maximum difference and the elements are all 0 or greater, just sort it and calculate from the ends. 
            int eleLength = elements.Length;
            Array.Sort(elements);
            maximumDifference = elements[eleLength - 1] - elements[0];
        }

    } // End of Difference Class

}
