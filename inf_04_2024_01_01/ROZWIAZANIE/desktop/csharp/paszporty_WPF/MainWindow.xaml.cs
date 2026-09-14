using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace paszporty_WPF
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

        string oczy = "niebieskie";

        private void Button_ok_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_imie.Text) ||
                string.IsNullOrWhiteSpace(textBox_nazwisko.Text) ||
                string.IsNullOrWhiteSpace(textBox_numer.Text))
            {
                MessageBox.Show("Wprowadź dane");
                return;
            }
            MessageBox.Show($"{textBox_imie.Text} {textBox_nazwisko.Text} kolor oczu {oczy}");
        }

        private void TextBox_numer_Leave(object sender, RoutedEventArgs e)
        {
            try
            {
                Image_osoba.Source = new BitmapImage(new Uri($"Images/{textBox_numer.Text}-zdjecie.jpg", UriKind.Relative));
                Image_odcisk.Source = new BitmapImage(new Uri($"Images/{textBox_numer.Text}-odcisk.jpg", UriKind.Relative));
            }
            catch
            {
                Image_osoba.Source = null;
                Image_odcisk.Source = null;
            }

        }

        private void RadioButton1_Click(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            oczy = radioButton.Content as String;
        }

    }
}
