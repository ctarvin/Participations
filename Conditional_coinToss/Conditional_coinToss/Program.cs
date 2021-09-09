using System;

namespace Conditional_coinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess heads or tails");
            string guess = Console.ReadLine();
            guess = guess.ToLower();

            Random rand = new Random();
            int randValue = rand.Next(0, 2);

            if (randValue == 0)
            {
                if (guess == "heads")
                {
                    Console.WriteLine("Heads, you were right!");
                }

                else if (guess == "tails")
                {
                    Console.WriteLine("Heads, better luck next time!");
                }
            }

            else if (randValue == 1)
            {
                if (guess == "heads")
                {
                    Console.WriteLine("Tails, better luck next time!");
                }

                else if (guess == "tails")
                    Console.WriteLine("Tails, you were right!");
                {

                }
            }

            Console.WriteLine("<<Created by Cole Tarvin>>");


        }
    }
}
