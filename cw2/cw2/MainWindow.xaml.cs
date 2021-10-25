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

namespace cw2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Cena.Content="0"; 
        }
        public MainWindow(string text) : this()
        {
            Cena.Content = text;
        }
        public MainWindow(string text,string poprzednia_wartosc) : this()
        {
            int zmienna=Convert.ToInt32(text.ToString()) + Convert.ToInt32(poprzednia_wartosc);
            Cena.Content=zmienna.ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 okno1 = new Window1();
            okno1.Show();
            this.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 okno2 = new Window2(Cena.Content.ToString());
            okno2.Show();
            this.Close();
        }
    }
}
