using Poczta.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poczta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int opcja = 0;

        private void Button_sprawdzCene_Click(object sender, EventArgs e)
        {
            switch (opcja)
            {
                case 0: label_cena.Text = "Cena: 1 zł"; pictureBox_zdjecie.Image = Resources.pocztowka; break;
                case 1: label_cena.Text = "Cena: 1,5 zł"; pictureBox_zdjecie.Image = Resources.list; break;
                case 2: label_cena.Text = "Cena: 10 zł"; pictureBox_zdjecie.Image = Resources.paczka; break;
            };
        }
        private void RadioButton_pocztowka_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            switch (radioButton.Tag)
            {
                case "pocztowka":opcja = 0; break;
                case "list": opcja = 1; break;
                case "paczka": opcja = 2; break;
            };
        }

        private void Button_zatwierdz_Click(object sender, EventArgs e)
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
