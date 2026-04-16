using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muzyka
{
    public partial class Form1 : Form
    {
        struct Rekord
        {
            public string artysta;
            public string album;
            public int numerPiosenki;
            public int rok;
            public long liczbaPobran;
        };

        static readonly List<Rekord> rekordy = new List<Rekord>();
        int aktualnaPozycja = 0;

        static void WczytajDane(string sciezka)
        {
            using (StreamReader streamReader = new StreamReader(sciezka))
            {
                rekordy.Clear();
                string linijka;
                while ((linijka = streamReader.ReadLine()) != null)
                {
                    Rekord rekord = new Rekord()
                    {
                        artysta = linijka,
                        album = streamReader.ReadLine(),
                        numerPiosenki = int.Parse(streamReader.ReadLine()),
                        rok = int.Parse(streamReader.ReadLine()),
                        liczbaPobran = long.Parse(streamReader.ReadLine())
                    };
                    rekordy.Add(rekord);
                    streamReader.ReadLine();
                }
            }

        }

        static void PokazRekord(int id, Label autor,Label nazwa, Label il_utworow, Label rok, Label pobran)
        {
            autor.Text = rekordy[id].artysta;
            nazwa.Text = rekordy[id].album;
            il_utworow.Text = rekordy[id].numerPiosenki.ToString() + " utworów";
            rok.Text = rekordy[id].rok.ToString();
            pobran.Text = rekordy[id].liczbaPobran.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WczytajDane("Dane.txt");
            if (rekordy.Count > 0)
            {
                PokazRekord(0, label_autor, label_tytul, label_iloscUtworow, label_rok, label_iloscPobran);
            }
        }

        private void Button_poprzedni_Click(object sender, EventArgs e)
        {
            if (aktualnaPozycja <= 0)
            {
                aktualnaPozycja = rekordy.Count-1;
            }
            else
            {
                aktualnaPozycja -= 1;
            }
            PokazRekord(aktualnaPozycja, label_autor, label_tytul, label_iloscUtworow, label_rok, label_iloscPobran);
        }

        private void Button_nastepny_Click(object sender, EventArgs e)
        {
            if (aktualnaPozycja >= rekordy.Count-1)
            {
                aktualnaPozycja = 0;
            }
            else
            {
                aktualnaPozycja += 1;
            }
            PokazRekord(aktualnaPozycja, label_autor, label_tytul, label_iloscUtworow, label_rok, label_iloscPobran);
        }

        private void Button_pobierz_Click(object sender, EventArgs e)
        {
            Rekord rekord = rekordy[aktualnaPozycja];
            rekord.liczbaPobran++;
            rekordy[aktualnaPozycja] = rekord;
            PokazRekord(aktualnaPozycja, label_autor, label_tytul, label_iloscUtworow, label_rok, label_iloscPobran);
        }
    }
}
