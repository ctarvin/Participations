using Newtonsoft.Json;
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
        bool showFront = false;
        bool showBack = false;
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
                    url = api.next;

                } while (api.next != null);
            }
        }

        private void lstPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Results selection = (Results)lstPokemon.SelectedItem;

            string json;

            string url = selection.url;

            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(url).Result;

                var api = JsonConvert.DeserializeObject<Pokemon>(json);

                imgPoke.Source = new BitmapImage(new Uri(api.sprites.front_default));

                showFront = false;

                txtWeight.Text = api.weight.ToString()+" lbs";
                txtHeight.Text = api.height.ToString()+" m";

            }
        }

        private void btnSwitch_Click(object sender, RoutedEventArgs e)
        {
            Results selection = (Results)lstPokemon.SelectedItem;

            string json;

            string url = selection.url;

            using (var client = new HttpClient())
            {
                json = client.GetStringAsync(url).Result;
                var api = JsonConvert.DeserializeObject<Pokemon>(json);

                if (showFront == true)
                {
                    imgPoke.Source = new BitmapImage(new Uri(api.sprites.front_default));
                    showFront = false;
                }
                else
                {
                    imgPoke.Source = new BitmapImage(new Uri(api.sprites.back_default));
                    showFront = true;
                }
            }
        }
    }
}
