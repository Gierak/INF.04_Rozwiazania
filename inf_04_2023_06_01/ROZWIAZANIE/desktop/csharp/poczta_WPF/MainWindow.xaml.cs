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

namespace poczta_WPF
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int opcja = 0;

        private void Button_sprawdzCene_Click(object sender, RoutedEventArgs e)
        {
            switch (opcja)
            {
                case 0: label_cena.Content = "Cena: 1 zł"; Image_zdjecie.Source = new BitmapImage(new Uri("/Images/pocztowka.png", UriKind.Relative)); break;
                case 1: label_cena.Content = "Cena: 1,5 zł"; Image_zdjecie.Source = new BitmapImage(new Uri("/Images/list.png", UriKind.Relative)); break;
                case 2: label_cena.Content = "Cena: 10 zł"; Image_zdjecie.Source = new BitmapImage(new Uri("/Images/paczka.png", UriKind.Relative)); break;
            }
            ;
        }
        private void RadioButton_pocztowka_Click(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            switch (radioButton.Tag)
            {
                case "pocztowka": opcja = 0; break;
                case "list": opcja = 1; break;
                case "paczka": opcja = 2; break;
            }
            ;
        }

        private void Button_zatwierdz_Click(object sender, RoutedEventArgs e)
        {

            if (textBox_kodPocztowy.Text.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
                return;
            }

            if (!int.TryParse(textBox_kodPocztowy.Text, out _))
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr");
                return;
            }

            MessageBox.Show("Dane przesyłki zostały wprowadzone");

        }

    }
}
