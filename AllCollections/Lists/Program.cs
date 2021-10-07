using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();

            do
            {
                Console.WriteLine("Insert a grade to store in your list.");
                int grade = Convert.ToInt32(Console.ReadLine());

                grades.Add(grade);

                Console.WriteLine("Do you have another grade to add? yes or no.");
            } while (Console.ReadLine().ToLower() == "yes");

            int runningtotal = 0;
            int averagegrade = 0;
            foreach (int grade in grades)
            {
                runningtotal += grade;
                averagegrade = runningtotal / grades.Count;
            }

            Console.WriteLine($"Your average grade is {averagegrade.ToString("N1")}");
        }
    }
}
