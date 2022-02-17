using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Participation
{
    internal class CarOwners
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Make {get;set;}
        public string Model {get;set;}
        public string Year {get;set;}
        public string Color { get; set; }


        public CarOwners()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Make     = string.Empty;
            Model    = string.Empty;
            Year     = string.Empty;
            Color = string.Empty;
        }

        public CarOwners(string owner)
        {
            var info = owner.Split();

            FirstName = info[1];
            LastName = info[2];
            Make = info[3];
            Model = info[4];
            Year = info[5];
            Color = info[6];
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} owns a {Color} {Year} {Make} {Model}";
        }

    }
}
