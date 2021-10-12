using System;
using System.Collections.Generic;

namespace Collections_MinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> examgrades = new List<int>();

            do
            {
                Console.WriteLine("Please insert your exam score.");
                int grade = Convert.ToInt32(Console.ReadLine());

                examgrades.Add(grade);

                Console.WriteLine("Do you have another grade to add? yes or no.");
            } while (Console.ReadLine().ToLower() == "yes");

            int sum = 0;
            int avg = 0;
            int min = examgrades[0];
            int max = examgrades[0];

            foreach (int grade in examgrades)
            {
                sum += grade;
                avg = sum / examgrades.Count;
                
            }
            foreach (int grade in examgrades)
            {
                if (min > grade)
                {
                    min = grade;
                }
            }
            foreach (int grade in examgrades)
            {
                if (max < grade)
                {
                    max = grade;
                }
            }

            Console.WriteLine($"The average exam score is {avg.ToString("N0")}");
            Console.WriteLine($"The minimum exam score is {min.ToString("N0")}");
            Console.WriteLine($"The maximum exam score is {max.ToString("N0")}");
        }
    }
}
