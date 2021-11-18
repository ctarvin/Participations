using System;
using System.Collections.Generic;

namespace Toys
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ToyBox> toyboxes = new List<ToyBox>();

            do
            {
                ToyBox tb = new ToyBox();
                Console.WriteLine("Who owns the ToyBox?");
                tb.Owner = Console.ReadLine();
                Console.WriteLine($"Where is {tb.Owner}'s ToyBox located?");
                tb.Location = Console.ReadLine();

                toyboxes.Add(tb);
                Console.WriteLine("Do you want to create another ToyBox? y or n");
            } while (Console.ReadLine().ToLower() != "n");

            for (int i = 0; i < toyboxes.Count; i++)
            {
                Console.WriteLine($"Time to fill up {toyboxes[i].Owner}'s ToyBox!");

                do
                {
                    Toy t = new Toy();

                    t.Manufacturer = Console.ReadLine();
                    t.Name = Console.ReadLine();
                    t.Price = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Do you have any notes for this toy? y or n");
                    while (Console.ReadLine().ToLower() != "n")
                    {
                        Console.WriteLine("What is your note?");
                        t.SetNotes(Console.ReadLine());

                        Console.WriteLine("Do you have another note to add for this toy? y or n");
                    }

                    toyboxes[i].Toys.Add(t);
                    Console.WriteLine("Do you want to create another Toy? y or n");
                } while (Console.ReadLine().ToLower() != "n");

            }





            /*
            ToyBox tb = new ToyBox();
            tb.Location = "Norman";
            tb.Owner = "Kaylee";
            tb.Toys.Add(new Toy()
            {
                Manufacturer = "Hasbro",
                Name = "Mr. Potato Head",
                Price = 14.99,
            }) ;

            ToyBox tb2 = new ToyBox();
            tb2.Location = "Dallas";
            tb2.Owner = "Swetha";
            tb2.Toys.Add(new Toy()
            {
                Manufacturer = "Pokemon",
                Name = "Pikachu",
                Price = 15.99,
            }) ; */

        }

        
    }
}
