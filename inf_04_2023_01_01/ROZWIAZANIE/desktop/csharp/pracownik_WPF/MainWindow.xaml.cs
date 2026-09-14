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

namespace pracownik_WPF
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

        readonly string litery = "qwertyuiopasdfghjklzxcvbnm";
        readonly string wielkieLitery = "QWERTYUIOPASDFGHJKLZXCVBNM";
        readonly string cyfry = "1234567890";
        readonly string znakispecjalne = "!@#$%^&*()_+-=";
        readonly Random random = new Random();
        string haslo = "";

        private void Button_generuj_Click(object sender, RoutedEventArgs e)
        {
            haslo = "";
            for (int i = 0; i < int.Parse(textBox_ileZnakow.Text); i++)
            {
                haslo += litery[random.Next(litery.Length)];
            }

            char[] hasloTablica = haslo.ToCharArray();

            if (checkBox_maleWielkie.IsChecked == true)
            {
                hasloTablica[0] = wielkieLitery[random.Next(wielkieLitery.Length)];
            }

            if (checkBox_cyfry.IsChecked == true)
            {
                hasloTablica[1] = cyfry[random.Next(cyfry.Length)];
            }

            if (checkBox_specjalne.IsChecked == true)
            {
                hasloTablica[2] = znakispecjalne[random.Next(0, znakispecjalne.Length)];
            }

            haslo = new string(hasloTablica);

            MessageBox.Show(haslo);
        }

        private void Button_zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Dane pracownika: {textBox_imie.Text} {textBox_nazwisko.Text} {comboBox_stanowisko.Text} Hasło: {haslo}");
        }


    }
}
