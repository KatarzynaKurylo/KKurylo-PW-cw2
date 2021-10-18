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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            cena.Content=0;
        }

        private void Mercedes_Checked(object sender, RoutedEventArgs e)
        {
            if (Mercedes.IsChecked==true)
            {
                ///cena += 100000;
            }
        }

        //private void Ferrari_Checked(object sender, RoutedEventArgs e)
       // {
       //     if (Ferrari.IsChecked == true)
        //    {

        //    }
       // }

        private void Fiat_Checked(object sender, RoutedEventArgs e)
        {
            if (Fiat.IsChecked == true)
            {

            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
