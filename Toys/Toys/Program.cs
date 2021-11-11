using System;

namespace Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy Toy1 = new Toy();
            Toy1.Manufacturer = "Hasbro";
            Toy1.Name = "GI Joe";
            Toy1.Price = 34.99;
            Toy1.SetNotes("Tall toy man");
            Console.WriteLine(Toy1.Manufacturer);
            Console.WriteLine(Toy1.Name);
            Console.WriteLine(Toy1.Price);
            Console.WriteLine(Toy1.GetAisle());
            Console.WriteLine(Toy1.GetNotes());

            Console.WriteLine();

            Toy Toy2 = new Toy();
            Toy2.Manufacturer = "Hasbro";
            Toy2.Name = "Barbie";
            Toy2.Price = 29.49;
            Toy2.SetNotes("Tall toy woman");
            Console.WriteLine(Toy2.Manufacturer);
            Console.WriteLine(Toy2.Name);
            Console.WriteLine(Toy2.Price);
            Console.WriteLine(Toy2.GetAisle());
            Console.WriteLine(Toy2.GetNotes());
        }

    }
}
