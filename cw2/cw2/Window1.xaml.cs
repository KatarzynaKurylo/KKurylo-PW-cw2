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
    public partial class Window1 : Window
    {
        private string text;
        public Window1()
        {
            InitializeComponent();
            cena.Content="0";

        }
        
        private void Ferrari_Checked(object sender, RoutedEventArgs e)
        {
            Radio.IsChecked = false;
            Klimatyzacja.IsChecked = false;
            Podgrzewanie.IsChecked = false;
            GPS.IsChecked = false;
            Polisa.Text = "0";
            if (Ferrari.IsChecked == true)
            {
                cena.Content="600000";
            }
        }
        private void Mercedes_Checked(object sender, RoutedEventArgs e)
        {
            Radio.IsChecked = false;
            Klimatyzacja.IsChecked = false;
            Podgrzewanie.IsChecked = false;
            GPS.IsChecked = false;
            Polisa.Text = "0";
            if (Mercedes.IsChecked == true)
            {
                cena.Content="100000";
            }
        }
        private void Fiat_Checked(object sender, RoutedEventArgs e)
        {
            Radio.IsChecked = false;
            Klimatyzacja.IsChecked = false;
            Podgrzewanie.IsChecked = false;
            GPS.IsChecked = false;
            Polisa.Text = "0";
            if (Fiat.IsChecked == true)
            {
                cena.Content="50000";
            }
        }
        public void Radio_Checked(object sender, RoutedEventArgs e)
        {
            if (Radio.IsChecked==true)
            {
                int zmienna=Convert.ToInt32(cena.Content)+50;
                cena.Content=zmienna.ToString();
            }
        }
        private void Radio_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Radio.IsChecked == false)
            {
                int zmienna = Convert.ToInt32(cena.Content) - 50;
                cena.Content = zmienna.ToString();
            }
        }
        public void Klimatyzacja_Checked(object sender, RoutedEventArgs e)
        {
            if (Klimatyzacja.IsChecked==true)
            {
                int zmienna=Convert.ToInt32(cena.Content) + 200;
                cena.Content=zmienna.ToString();
            }   
        }
        private void Klimatyzacja_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Klimatyzacja.IsChecked == false)
            {
                int zmienna = Convert.ToInt32(cena.Content) - 200;
                cena.Content = zmienna.ToString();
            }
        }
        private void Podgrzewanie_Checked(object sender, RoutedEventArgs e)
        {
            if (Podgrzewanie.IsChecked==true)
            {
                int zmienna=Convert.ToInt32(cena.Content) + 300;
                cena.Content=zmienna.ToString();
            }
        }
        public void Podgrzewanie_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Podgrzewanie.IsChecked == false)
            {
                int zmienna = Convert.ToInt32(cena.Content) - 300;
                cena.Content = zmienna.ToString();
            }
        }
        private void GPS_Checked(object sender, RoutedEventArgs e)
        {
            if (GPS.IsChecked==true)
            {
                int zmienna=Convert.ToInt32(cena.Content) + 100;
                cena.Content=zmienna.ToString();
            }
        }
        public void GPS_Unchecked(object sender, RoutedEventArgs e)
        {
            if (GPS.IsChecked == false)
            {
                int zmienna = Convert.ToInt32(cena.Content) - 100;
                cena.Content = zmienna.ToString();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text = cena.Content.ToString();
            MainWindow mainWindow = new MainWindow(text);
            mainWindow.Show();
            this.Close();
        }
        int zapamietaj=0;
        private void Polisa_TextChanged(object sender, TextChangedEventArgs e)
        {
            int iVal;
            if (string.IsNullOrEmpty(Polisa.Text))
            {
                iVal=0;
            }
            else
            {
                int.TryParse(Polisa.Text, out iVal);
            }
            int zmienna = Convert.ToInt32(cena.Content) + iVal - zapamietaj;
            cena.Content = zmienna.ToString();
            zapamietaj = iVal;
        }
    }
}