using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    class _30DaysDay21Generics
	// https://www.hackerrank.com/challenges/30-generics/problem?utm_campaign=30_days_of_code_continuous&utm_medium=email&utm_source=daily_reminder

	// Use generics to print out arrays with two different data types. Only code added is the entire PrintArray method. 

	{   /**
	*    Name: PrintArray
	*    Print each element of the generic array on a new line. Do not return anything.
	*    @param A generic array
	**/
		// Write your code here
		public static void PrintArray<T>(T[] t)
		{
			for (int i = 0; i < t.Length; i++)
			{
				Console.WriteLine(t[i]);
			}
		}

		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int[] intArray = new int[n];
			for (int i = 0; i < n; i++)
			{
				intArray[i] = Convert.ToInt32(Console.ReadLine());
			}

			n = Convert.ToInt32(Console.ReadLine());
			string[] stringArray = new string[n];
			for (int i = 0; i < n; i++)
			{
				stringArray[i] = Console.ReadLine();
			}

			PrintArray<Int32>(intArray);
			PrintArray<String>(stringArray);
		}
	}
}
