using System;

namespace StringManipulation
{
    class Program
    {
        static string statement = "Programming today is a race between software engineers striving to build bigger " +
            "and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

        static void Main(string[] args)
        {
            Console.WriteLine(statement);
            Console.WriteLine();

            Console.WriteLine("What word would you like to change in the above statement?");
            string oldword = Console.ReadLine();

            do
            {
                Console.WriteLine($"Sorry, I could not find your word '{oldword}'");
                
                string reverse = "";
                for (int i = 0; i < oldword.Length -1; i--)
                {
                    reverse += oldword[i];
                }
                Console.WriteLine(reverse);

                Console.WriteLine("Please insert another word.");
                oldword = Console.ReadLine();

            } while (statement.Contains(oldword) == false);

            Console.WriteLine("What word would you like to change it to?");
            string newword = Console.ReadLine();

            string newstatement = statement.Replace(oldword, newword);
            Console.WriteLine(newstatement);

        }
    }
}
