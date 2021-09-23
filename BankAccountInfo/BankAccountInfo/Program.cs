using System;

namespace BankAccountInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many bank accounts do you currently have?");
            string input = Console.ReadLine();

            double numOfAccounts;
            while (double.TryParse(input, out numOfAccounts) == false)
            {
                Console.WriteLine($"Sorry, {input} is not a valid input. Please input a number (i.e. 4).");
                input = Console.ReadLine();
            }

            double runningTotal = 0;
            for (int i = 0; i < numOfAccounts; i++)
            {
                Console.WriteLine($"What is the balance of account {i+1}? Enter as an integer (i.e. 3000).");
                runningTotal = runningTotal + (Convert.ToDouble(Console.ReadLine()));
            }

            double averageTotal = runningTotal / numOfAccounts;
            Console.WriteLine($"Your total balance across all accounts is {runningTotal.ToString("C")}");

            if (averageTotal > 5000)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Your average balance across all accounts is {averageTotal.ToString("C")}");
                Console.ForegroundColor = ConsoleColor.White;
            }

            else
            {
                Console.WriteLine($"Your average balance across all accounts is {averageTotal.ToString("C")}");
            }
            

        }
    }
}
