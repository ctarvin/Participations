using System;

namespace AllCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert your first subject");
            string subject1 = Console.ReadLine().ToUpper();
            Console.WriteLine("Insert your second subject");
            string subject2 = Console.ReadLine().ToUpper();
            Console.WriteLine("Insert your third subject");
            string subject3 = Console.ReadLine().ToUpper();

            string[] subjects = { subject1, subject2, subject3 };

            Console.WriteLine("Insert your first course number");
            string courseno1 = Console.ReadLine();
            Console.WriteLine("Insert your second course number");
            string courseno2 = Console.ReadLine();
            Console.WriteLine("Insert your third coures number");
            string courseno3 = Console.ReadLine();

            string[] coursenums = { courseno1, courseno2, courseno3 };

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine(subjects[i]+coursenums[i]);
            }
        }
    }
}
