using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    class _30DaysDay2Operators
    {
        // From this: https://www.hackerrank.com/challenges/30-operators/problem
        /*Objective
        In this challenge, you'll work with arithmetic operators. Check out the Tutorial tab for learning materials and an instructional video!

        Task
        Given the meal price (base cost of a meal), tip percent (the percentage of the meal price being added as tip), and tax percent (the percentage of the meal price being added as tax) for a meal, find and print the meal's total cost.

        Note: Be sure to use precise values for your calculations, or you may end up with an incorrectly rounded result!

        Input Format

        There are 3 lines of numeric input:
        The first line has a double, mealCost (the cost of the meal before tax and tip).
        The second line has an integer, tipPercent (the percentage of mealCost being added as tip).
        The third line has an integer, taxPercent (the percentage of mealCost being added as tax).

        Output Format

        Print the total meal cost, where totalCost is the rounded integer result of the entire bill (mealCost with added tax and tip).

        Sample Input

        12.00
        20
        8
        Sample Output
        15
         */
        static void Operators()
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }


        // Complete the solve function below.
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            // Decimal is supposed to be better for $$ so do lots of casting
            // https://exceptionnotfound.net/decimal-vs-double-and-other-tips-about-number-types-in-net/
            decimal tip = ((decimal)meal_cost * ((decimal)tip_percent / 100));
            decimal tax = ((decimal)meal_cost * ((decimal)tax_percent / 100));
            decimal totalCost = (decimal)meal_cost + tip + tax;
            decimal roundedCost = Math.Round(totalCost);
            Console.WriteLine(roundedCost);


            // This also returns the correct # but is less ideal - but faster. 
            // double tip = (meal_cost * ((double)tip_percent / 100));
            // double tax = (meal_cost * ((double)tax_percent / 100)); 
            // double totalCost = (double)meal_cost + tip + tax;
            // double roundedCost = Math.Round(totalCost);
            // Console.WriteLine(roundedCost); 
        }
    }
}
