﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Beginner.Models
{
    public class PokemonInfo
    {
        public List<Ability> abilities { get; set; }
        public int base_experience { get; set; }
        public List<Form> forms { get; set; }
        public List<GameIndice> game_indices { get; set; }
        public int height { get; set; }
        public List<HeldItem> held_items { get; set; }
        public int id { get; set; }
        public bool is_default { get; set; }
        public string location_area_encounters { get; set; }
        public List<Move> moves { get; set; }
        public string name { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public Species species { get; set; }
        public Sprites sprites { get; set; }
        public List<Stat> stats { get; set; }
        public List<Type> types { get; set; }
        public int weight { get; set; }
    }

    public class Ability2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Ability
    {
        public Ability2 ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }

    public class Form
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class GameIndice
    {
        public int game_index { get; set; }
        public Version version { get; set; }
    }

    public class Item
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Version2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class VersionDetail
    {
        public int rarity { get; set; }
        public Version2 version { get; set; }
    }

    public class HeldItem
    {

    }
}