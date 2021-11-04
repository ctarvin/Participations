using System;
using System.Collections.Generic;

namespace MethodsParallelArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentNames = { "Cole", "Andrew", "Mathieu", "Jakoby", "Ali" };

            int[] studentIDs = { 113460481, 113460482, 113460483, 113460484, 113460485 };

            List<List<double>> studentGrades = new List<List<double>>();
            studentGrades.Add(CreateRandomSizedListWithRandomValues());
            studentGrades.Add(CreateRandomSizedListWithRandomValues());
            studentGrades.Add(CreateRandomSizedListWithRandomValues());
            studentGrades.Add(CreateRandomSizedListWithRandomValues());
            studentGrades.Add(CreateRandomSizedListWithRandomValues());

            for (int i = 0; i < studentGrades.Count; i++)
            {
                StudentInformation(studentNames[i], studentIDs[i], studentGrades[i]);
            }

        }

        static void StudentInformation(string studentName, int studentID, List<double> allGrades)
        {
            Console.WriteLine($"{studentName} - {studentID}");

            double runningTotal = 0;
            double average = 0;

            foreach (int item in allGrades)
            {
                runningTotal += item;
            }
            average = runningTotal / allGrades.Count;

            Console.WriteLine($"This student has {allGrades.Count} grades and their average score is {average}\n");
        }

        static List<double> CreateRandomSizedListWithRandomValues()
        {
            List<double> randoGrades = new List<double>();
            Random rand = new Random();
            int numberofGrades = rand.Next(3, 10);

            for (int i = 0; i < numberofGrades; i++)
            {
                double grade = rand.NextDouble() * 100;
                randoGrades.Add(grade);
            }

            return randoGrades;
        }
    }
}
