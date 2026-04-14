using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracownik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly string litery = "qwertyuiopasdfghjklzxcvbnm";
        readonly string wielkieLitery = "QWERTYUIOPASDFGHJKLZXCVBNM";
        readonly string cyfry = "1234567890";
        readonly string znakispecjalne = "!@#$%^&*()_+-=";
        readonly Random random = new Random();
        string haslo = "";

        private void Button_generuj_Click(object sender, EventArgs e)
        {
            haslo = "";
            for (int i = 0; i < int.Parse(textBox_ileZnakow.Text); i++)
            {
                haslo += litery[random.Next(litery.Length)];
            }

            char[] hasloTablica = haslo.ToCharArray();

            if (checkBox_maleWielkie.Checked)
            {
                hasloTablica[0]= wielkieLitery[random.Next(wielkieLitery.Length)];
            }

            if (checkBox_cyfry.Checked)
            {
                hasloTablica[1]= cyfry[random.Next(cyfry.Length)];
            }

            if (checkBox_specjalne.Checked)
            {
                hasloTablica[2]= znakispecjalne[random.Next(0, znakispecjalne.Length)];
            }

            haslo = new string(hasloTablica);

            MessageBox.Show(haslo);
        }

        private void Button_zatwierdz_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Dane pracownika: {textBox_imie.Text} {textBox_nazwisko.Text} {comboBox_stanowisko.Text} Hasło: {haslo}");
        }
    }
}
