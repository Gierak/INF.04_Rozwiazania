using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaletaRGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int r = 255;
        int g = 255;
        int b = 255;

        private void Button_pobierz_Click(object sender, EventArgs e)
        {
            label_zapisane.Text = $"{r}, {g}, {b}";
            label_zapisane.BackColor = Color.FromArgb(r, g, b);
        }

        private void TrackBar_czerwony_Scroll(object sender, EventArgs e)
        {
            r = trackBar_czerwony.Value;
            label_czerwony.Text = r.ToString();
            panel_podglad.BackColor = Color.FromArgb(r, g, b);
        }

        private void TrackBar_zielony_Scroll(object sender, EventArgs e)
        {
            g = trackBar_zielony.Value;
            label_zielony.Text = g.ToString();
            panel_podglad.BackColor = Color.FromArgb(r, g, b);
        }

        private void TrackBar_niebieski_Scroll(object sender, EventArgs e)
        {
            b = trackBar_niebieski.Value;
            label_niebieski.Text = b.ToString();
            panel_podglad.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
