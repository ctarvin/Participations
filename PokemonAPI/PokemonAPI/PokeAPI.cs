using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI
{
    public class PokeAPI
    {
        public Info info { get; set; }
        public List<Pokemon> results { get; set; }
    }
    public class Pokemon
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int height { get; set; }
        public string image { get; set; }
        public string url { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
    public class Info
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
    }
}
