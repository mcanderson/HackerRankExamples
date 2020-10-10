using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankExamples
{
    class _30DaysDay4ClassInstance
    {
        // https://www.hackerrank.com/challenges/30-class-vs-instance/problem
        /*
         * Objective
In this challenge, we're going to learn about the difference between a class and an instance; because this is an Object Oriented concept, it's only enabled in certain languages. Check out the Tutorial tab for learning materials and an instructional video!

Task
Write a Person class with an instance variable, age, and a constructor that takes an integer, initialAge, as a parameter. 
 The constructor must assign initialAge to age after confirming the argument passed as initialAge is not negative; if a negative argument is passed as initialAge, the constructor should set age to 0 and print Age is not valid, setting age to 0.. In addition, you must write the following instance methods:

yearPasses() should increase the age instance variable by 1.
amIOld() should perform the following conditional actions:
If age < 13, print You are young..
If age >= 13 and age < 18, print You are a teenager..
Otherwise, print You are old..
To help you learn by example and complete this challenge, much of the code is provided for you, but you'll be writing everything in the future. The code that creates each instance of your Person class is in the main method. Don't worry if you don't understand it all quite yet!

Note: Do not remove or alter the stub code in the editor.

Input Format

Input is handled for you by the stub code in the editor.

The first line contains an integer, T (the number of test cases), and the T subsequent lines each contain an integer denoting the age of a Person instance.
         * 
         */
        static void ClassInstances()
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
        }
    }

    class Person
    {
        public int age;
        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge
            // Confirm age is not negative
            if (initialAge < 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0.");
                age = 0;
            }
            else
            {
                age = initialAge;
            }
        }
        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console 
            // First case
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            // Second case
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            // Rest
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public void yearPasses()
        {
            // Increment the age of the person in here
            age++;
        }
    }
}
