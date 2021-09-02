using System;

namespace Participations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number. >>");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your second number. >>");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter your third number. >>");
            double thirdNumber = Convert.ToDouble(Console.ReadLine());
         
            double sum = firstNumber + secondNumber + thirdNumber;
            const double seven = 7.777;    
           
            double finalanswer = sum * seven;
            Console.WriteLine($"The sum of these three numbers is {sum.ToString("N3")}");
            Console.WriteLine($"The sum multiplied by 7.777 is {finalanswer.ToString("N3")}");
        }
    }
}
