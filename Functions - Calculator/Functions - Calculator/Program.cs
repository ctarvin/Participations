using System;

namespace Functions___Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("Cole Tarvin", "MIS3013", "21 Oct 2021");

            bool goAgain = false;
            bool shouldIusePreviousResult = false;
            do
            {
                Console.WriteLine("What type of calculation do you want to perform? +, -, #, / >>");
                string operation = Console.ReadLine();

                Console.WriteLine("What is the first operand?");
                double first = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is the second operand?");
                double second = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = Add(first, second);
                        break;
                    case "-":
                        result = Subtract(first, second);
                        break;
                    case "/":
                        result = Divide(first, second);
                        break;
                    case "*":
                        result = Multiply(first, second);
                        break;
                    default:
                        result = 0;
                        Console.WriteLine("Sorry, invalid operation.");
                        break;
                }
                Console.WriteLine($"{first.ToString("N")} {operation} {second.ToString("N")} = {result.ToString("N")}");

                Console.WriteLine("Do you want to perform another calculation? y/n");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "y")
                {
                    goAgain = true;
                }
                else
                {
                    goAgain = false;
                }
            } while (goAgain == true);
        }

        static double Add(double val1, double val2)
        {
            double sum = 0;
            sum = val1 + val2;

            return sum;

            //Or you can do this
            //return val1+ val2;
        }

        static double Subtract(double val1, double val2)
        {
            return val1 - val2;
        }

        static double Multiply(double val1, double val2)
        {
            return val1 * val2;
        }

        static double Divide(double val1, double val2)
        {
            return val1 / val2;
        }

        static void DeveloperInformation(string devname, string classname, string date)
        {
            Console.WriteLine($"Code written by {devname} for {classname} on {date}");
        }
    }
}
