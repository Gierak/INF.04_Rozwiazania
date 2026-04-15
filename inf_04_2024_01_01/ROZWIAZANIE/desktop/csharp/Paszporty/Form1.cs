using Paszporty.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paszporty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string oczy = "niebieskie";

        private void Button_ok_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_imie.Text) || string.IsNullOrWhiteSpace(textBox_nazwisko.Text))
            {
                MessageBox.Show("Wprowadź dane");
                return;
            }
            MessageBox.Show($"{textBox_imie.Text} {textBox_nazwisko.Text} kolor oczu {oczy}");
        }

        private void TextBox_numer_Leave(object sender, EventArgs e)
        {
            pictureBox_osoba.Image = Resources.ResourceManager.GetObject($"{textBox_numer.Text}-zdjecie") as Image;
            pictureBox_odcisk.Image = Resources.ResourceManager.GetObject($"{textBox_numer.Text}-odcisk") as Image;
        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            oczy = radioButton.Text;
        }
    }
}
