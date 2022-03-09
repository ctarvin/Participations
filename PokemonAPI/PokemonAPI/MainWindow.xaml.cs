﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PokemonAPI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string url = "https://pokeapi.co/api/v2/pokemon";
            string json;

            PokeAPI api;

            using (var client = new HttpClient())
            {
                do
                {
                     json = client.GetStringAsync(url).Result;
                     api = JsonConvert.DeserializeObject<PokeAPI>(json);

                    foreach (var pokemon in api.results)
                    {
                        lstPokemon.Items.Add(pokemon);
                    }
                    url = api.info.next;

                } while (api.info.next != null);
            }
        }
    }
}
