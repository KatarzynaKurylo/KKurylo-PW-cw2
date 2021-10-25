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
using System.Windows.Shapes;

namespace cw2
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private string wartosc;
        private string wyslij;
        public Window2(string poprzednia)
        {
            InitializeComponent();
            price.Content = "0";
            wyslij = poprzednia;
            combo.Items.Add("100");
            combo.Items.Add("150");
            combo.Items.Add("300");
            combo.Items.Add("500");
        }
        private void Benzyna_Checked(object sender, RoutedEventArgs e)
        {
            if (Benzyna.IsChecked == true)
            {
                price.Content = "10000";
            }
        }
        private void Diesel_Checked(object sender, RoutedEventArgs e)
        {
            if (Diesel.IsChecked == true)
            {
                price.Content="20000";
            }
        }
        private void Hybryda_Checked(object sender, RoutedEventArgs e)
        {
            if (Hybryda.IsChecked == true)
            {
                price.Content="50000";
            }
        }
        private void Gaz_Checked(object sender, RoutedEventArgs e)
        {
            if (Gaz.IsChecked==true)
            {
                price.Content="25000";
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            wartosc=price.Content.ToString();
            MainWindow okno_koncowe=new MainWindow(wartosc,wyslij);
            okno_koncowe.Show();
            this.Close();
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int iVal;
            if (int.TryParse(combo.Text, out iVal))
            {
                int zmienna = Convert.ToInt32(price.Content) + iVal*100;
                price.Content = zmienna.ToString();
            }
        }

    }
}
