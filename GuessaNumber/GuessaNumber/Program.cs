using System;

namespace GuessaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int Maxnumber;
            int Minnumber;
            int numGuess;

            Console.WriteLine("Please insert the minimum value you would like to guess.");
            string minimum = Console.ReadLine();
            bool isMinValid = int.TryParse(minimum, out Minnumber);

            while (int.TryParse(minimum, out Minnumber) == false)
            {
                Console.WriteLine($"Sorry, {minimum} is invalid. Please try again.");
                minimum = Console.ReadLine();
            }

            Console.WriteLine("Now, please insert the maximum value you would like to guess.");
            string maximum = Console.ReadLine();
            bool isMaxValid = int.TryParse(maximum, out Maxnumber);

            while (int.TryParse(maximum, out Maxnumber) == false)
            {
                Console.WriteLine($"Sorry, {maximum} is invalid. Please try again.");
                maximum = Console.ReadLine();
            }

            Random random = new Random();

            int randValue = random.Next(Minnumber, Maxnumber);

            Console.WriteLine($"Please guess a random number between {minimum} and {maximum}.");

            string userGuess = Console.ReadLine();
            bool isGuessValid = int.TryParse(userGuess, out numGuess);

            while (int.TryParse(userGuess, out numGuess) == false)
            {
                Console.WriteLine($"Sorry, {userGuess} is not valid. Please try again.");
                userGuess = Console.ReadLine();
             
            }

            while (numGuess != randValue)
            {
                Console.WriteLine("Incorrect guess. Try again!");
                numGuess = Convert.ToInt32(Console.ReadLine()); 
            }

            Console.WriteLine($"Congrats, your luck finally came into play! {numGuess} was the right answer!");
        }
    }
}
