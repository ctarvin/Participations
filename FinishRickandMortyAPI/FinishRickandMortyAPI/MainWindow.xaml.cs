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

namespace FinishRickandMortyAPI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string url = "https://rickandmortyapi.com/api/character";

            string json;

            //HttpClient client = new HttpClient();

            //client.Dispose();

            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(url).Result;

                RickAndMortyAPI api = JsonConvert.DeserializeObject<RickAndMortyAPI>(json);

                foreach (var character in api.results)
                {
                    lstCharacters.Items.Add(character);
                }
            }

        }

        private void lstCharacters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character selected = (Character)lstCharacters.SelectedItem;

            imgCharacter.Source = new BitmapImage(new Uri(selected.image));
        }
    }
}
