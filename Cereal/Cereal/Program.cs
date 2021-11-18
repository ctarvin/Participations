using System;
using System.Collections.Generic;
using System.IO;

namespace Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linesOfFile = File.ReadAllLines("Cereal_Data.txt");

            List<Cereal> listofCereal = new List<Cereal>();

            for (int i = 0; i < linesOfFile.Length; i++)
            {
                string line = linesOfFile[i];
                string[] piecesofline = line.Split("|");

                Cereal C = new Cereal();

                C.Name = piecesofline[0];
                C.Manufacturer = piecesofline[1];
                C.Calories = Convert.ToDouble(piecesofline[2]);
                C.Cups = Convert.ToDouble(piecesofline[3]);

                listofCereal.Add(C);
            }

            Console.WriteLine("Below is a list of all cereals with 1 or more cups");
            foreach (Cereal cereal in listofCereal)
            {
                if (cereal.Cups >= 1)
                {
                    Console.WriteLine(cereal.Name);
                    Console.WriteLine(cereal.Manufacturer);
                    Console.WriteLine(cereal.Calories);
                    Console.WriteLine(cereal.Cups);
                }
            }
            Console.WriteLine("Below is a list of all cereals with 100 calories or less");
            foreach (Cereal cereal in listofCereal)
            {
                if (cereal.Calories <= 100)
                {
                    Console.WriteLine(cereal.Name);
                    Console.WriteLine(cereal.Manufacturer);
                    Console.WriteLine(cereal.Calories);
                    Console.WriteLine(cereal.Cups);
                }
            }
        }
    }
}
