using System;
using System.Collections.Generic;
using System.Text;

namespace Toys
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes { get; set; }

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = string.Empty;
        }
        public string GetAisle()
        {
            Random rand = new Random();
            double randvalue = rand.Next(1, 25);

            return Manufacturer[0].ToString().ToUpper() + randvalue;
        }
        public void SetNotes(string NewNotes)
        {
            Notes = NewNotes;
            
        }
        public string GetNotes()
        {
            return Notes;
        }
    }
}
