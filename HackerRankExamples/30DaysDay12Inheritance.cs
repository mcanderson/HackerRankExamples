using System;
using System.Collections.Generic;
using System.Text;

// Had to rename this one's namespace because another class has a person too
namespace HackerRankExamples2
{
    // https://www.hackerrank.com/challenges/30-inheritance/problem

    /*
     * Objective
        Today, we're delving into Inheritance. Check out the attached tutorial for learning materials and an instructional video!

        Task
        You are given two classes, Person and Student, where Person is the base class and Student is the derived class. Completed code for Person and a declaration for Student are provided for you in the editor. Observe that Student inherits all the properties of Person.

        Complete the Student class by writing the following:

        A Student class constructor, which has 4 parameters:
        A string, firstName.
        A string, lastName.
        An integer, id.
        An integer array (or vector) of test scores, scores.
        A char calculate() method that calculates a Student object's average and returns the grade character representative of their calculated average:
        Grading.png
        O 90 <= a <= 100
        E 80 <= a < 90
        A 70 <= a < 80
        P 55 <= a < 70
        D 40 <= a < 55
        T a < 40 (but technically also 0 <= a)

        Input Format

        The locked stub code in your editor calls your Student class constructor and passes it the necessary arguments. It also calls the calculate method (which takes no arguments).

        You are not responsible for reading the following input from stdin:
        The first line contains firstName, lastName, and id, respectively. The second line contains the number of test scores. The third line of space-separated integers describes scores.

        Constraints
        1 <= |firstName|,|lastName| <= 10
        |id| === 7
        0 <= score, average <= 100

        Output Format

        This is handled by the locked stub code in your editor. Your output will be correct if your Student class constructor and calculate() method are properly implemented.

        Sample Input

        Heraldo Memelli 8135627
        2
        100 80
        Sample Output

         Name: Memelli, Heraldo
         ID: 8135627
         Grade: O
     * 
     */
    class _30DaysDay12Inheritance
    {
        static void Main()
        {
			string[] inputs = Console.ReadLine().Split();
			string firstName = inputs[0];
			string lastName = inputs[1];
			int id = Convert.ToInt32(inputs[2]);
			int numScores = Convert.ToInt32(Console.ReadLine());
			inputs = Console.ReadLine().Split();
			int[] scores = new int[numScores];
			for (int i = 0; i < numScores; i++)
			{
				scores[i] = Convert.ToInt32(inputs[i]);
			}

			Student s = new Student(firstName, lastName, id, scores);
			s.printPerson();
			Console.WriteLine("Grade: " + s.Calculate() + "\n");
		}
    }
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    class Student : Person
    {
        private int[] testScores { get; set; }

        /*    
      *   Class Constructor
      *   
      *   Parameters: 
      *   firstName - A string denoting the Person's first name.
      *   lastName - A string denoting the Person's last name.
      *   id - An integer denoting the Person's ID number.
      *   scores - An array of integers denoting the Person's test scores.
      */
        // Write your constructor here
        public Student(string firstName, string lastName, int identification, int[] scores) : base(firstName, lastName, identification)
        {
            this.testScores = scores;
        }

        /*    
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here
        public char Calculate()
        {
            // Average to use to determine grade
            int avgTotal;
            // Running total of scores
            int sumGrades = 0;
            // Grade to return - would initialize to some default or error value but none given in requirements
            char grade;

            // Calculate the sum of the scores
            for (int i = 0; i < this.testScores.Length; i++)
            {
                sumGrades += this.testScores[i];
            }
            // Then the average to be used to determine grade letter
            avgTotal = sumGrades / this.testScores.Length;

            // And loop through until we find the right grade
            if ((avgTotal >= 0 && avgTotal < 40) == true)
            {
                grade = 'T';
                return grade;
            }
            else if ((avgTotal >= 41 && avgTotal < 55) == true)
            {
                grade = 'D';
                return grade;
            }
            else if ((avgTotal >= 55 && avgTotal < 70) == true)
            {
                grade = 'P';
                return grade;
            }
            else if ((avgTotal >= 70 && avgTotal < 80) == true)
            {
                grade = 'A';
                return grade;
            }
            else if ((avgTotal >= 80 && avgTotal < 90) == true)
            {
                grade = 'E';
                return grade;
            }
            // Technically should have some default value for char if there's a data issue
            // this would be an else if if ((avgTotal >= 90 && avgTotal <= 100) == true) 
            else
            {
                grade = 'O';
                return grade;
            }
        }
    }
}
