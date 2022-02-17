using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace JSON_Participation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<CarOwners> car = new List<CarOwners>();
        public MainWindow()
        {
            InitializeComponent();

            string json = File.ReadAllText("Mock_Data_Car_Owners.json");

            var results = JsonConvert.DeserializeObject<List<CarOwners>>(json);

            foreach (CarOwners owner in results)
            {
                car.Add(new CarOwners(owner.ToString()));
                if (cboColors.Items.Contains(owner.Color) == false)
                {
                    cboColors.Items.Add(owner.Color);
                }
            }

            PopulateListBox(car);
            
        }
        private void PopulateColorBox()
        {
            cboColors.SelectedIndex = 12;
        }

        private void PopulateListBox(List<CarOwners> carOwners)
        {
            lstData.Items.Clear();
            foreach (var car in carOwners)
            {
                lstData.Items.Add(car);
            }
        }

        private void cboColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lstData.Items.Clear();
            foreach (CarOwners owners in car)
            {
                if (owners.Color = cboColors.SelectedItem)
                {
                    lstData.Items.Add(owners.Color);
                }
            }
        }
    }
}
