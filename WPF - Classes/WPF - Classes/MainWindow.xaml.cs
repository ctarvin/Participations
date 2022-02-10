using System;
using System.Collections.Generic;
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

namespace WPF___Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtManufacturer.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtURL.Clear();  
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            Toy t = new Toy();

            t.Manufacturer = txtManufacturer.Text;
            t.Name = txtName.Text;
            t.Price = Convert.ToDouble(txtPrice.Text);
            t.Image = txtURL.Text;

            if (string.IsNullOrWhiteSpace(txtManufacturer.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtURL.Text))
            {
                MessageBox.Show("Please make sure to enter values into every box!");
            }
            else
            {
                lstInformation.Items.Add(t);
                txtManufacturer.Clear();
                txtName.Clear();
                txtPrice.Clear();
                txtURL.Clear();
            }

        }

        private void lstInformation_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Toy selectedToy = (Toy)lstInformation.SelectedItem;

            MessageBox.Show(selectedToy.ToString());
        }
    }
}
