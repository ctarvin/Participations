using System;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a dog, monkey, or goat to hear what sound it makes!");
            string animal = Console.ReadLine();

            Console.WriteLine($"A {animal} makes the sound of {Speak(animal)}");
        }

        static string Speak(string animal)
        {
            string sound;
            switch (animal.ToLower())
            {
                case "dog":
                    sound = "'woof'";
                    break;
                case "monkey":
                    sound = "'ooooh ooooh aaaah aaaah'";
                    break;
                case "goat":
                    sound = "'baaaah'";
                    break;
                default:
                    sound = "This was not one of the options!";
                    break;
            }
            return sound;
        }
    }
}
