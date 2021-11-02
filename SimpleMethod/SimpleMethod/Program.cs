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
                    sound = "'Hi I am a dog'";
                    break;
                case "monkey":
                    sound = "'Hi I am a monkey'";
                    break;
                case "goat":
                    sound = "'Hi I am a goat'";
                    break;
                default:
                    sound = "Please choose a dog, monkey, or goat. I really don't want to code anything else";
                    break;
            }
            return sound;
        }
    }
}
