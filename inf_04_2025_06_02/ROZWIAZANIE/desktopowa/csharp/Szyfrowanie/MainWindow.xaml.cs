using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

namespace Szyfrowanie
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

        string szyfr = "";

        private void ButtonZaszyfruj_Click(object sender, RoutedEventArgs e)
        {
            int klucz = int.TryParse(tb_klucz.Text, out int poprawne) ? poprawne : 0;
            szyfr = Szyfr.Szyfrowanie(tb_tekst.Text, klucz);
            tb_wynik.Text = szyfr;
        }

        private void ButtonZapisz_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                {
                    streamWriter.Write(szyfr);
                }
            }
        }
    }
}
