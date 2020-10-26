using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    class _30DaysDay20Sorting
    {
        static void Main(String[] args)
        {
            // Number of elements to be sorted
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            // Array of elements to use bubble sort on
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            // Write Your Code Here
            int lastVal = a.Length - 1;
            int swapPosition;
            int counter = 0;

            while (lastVal > 0)
            {
                swapPosition = 0;
                // Essentially just copied the pseudocode/Java from the tutorial and it worked...but did have to add the swap counter in.
                for (int i = 0; i < lastVal; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        // Swap elements 'i' and 'i + 1':
                        int tmp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = tmp;

                        swapPosition = i;
                        counter++;
                    } // end if
                } // end for
                lastVal = swapPosition;
            } // end while
            Console.WriteLine("Array is sorted in " + counter + " swaps.");
            Console.WriteLine("First Element: " + a[0]);
            Console.WriteLine("Last Element: " + a[a.Length - 1]);
        }
    }
}
