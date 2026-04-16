namespace odtwarzacz_muzyki
{
    class Program
    {
        struct Rekord
        {
            public string artysta;
            public string album;
            public int numerPiosenki;
            public int rok;
            public long numerPobrania;
        };

        static List<Rekord> rekordy = [];

        static void WczytajDane(string sciezka)
        {
            using (StreamReader streamReader = new(sciezka))
            {
                rekordy.Clear();
                string linijka;
                while ((linijka = streamReader.ReadLine()!) != null)
                {
                    Rekord rekord = new()
                    {
                        artysta = linijka,
                        album = streamReader.ReadLine()!,
                        numerPiosenki = int.Parse(streamReader.ReadLine()!),
                        rok = int.Parse(streamReader.ReadLine()!),
                        numerPobrania = long.Parse(streamReader.ReadLine()!)
                    };
                    rekordy.Add(rekord);
                    streamReader.ReadLine();
                }
            }

        }

        /**********************************************
        nazwa funkcji:          WypiszDane
        opis funkcji:           Funkcja wypisuje dane z listy rekordów
        parametry:              brak
        zwracany typ i opis:    brak
        autor:                  Karol - Gierak - Gieracki (https://github.com/Gierak)
        ***********************************************/
        static void WypiszDane()
        {
            foreach (Rekord rekord in rekordy)
            {
                Console.WriteLine(rekord.artysta);
                Console.WriteLine(rekord.album);
                Console.WriteLine(rekord.numerPiosenki);
                Console.WriteLine(rekord.rok);
                Console.WriteLine(rekord.numerPobrania + Environment.NewLine);
            }
        }

        static void Main()
        {
            WczytajDane("pliki2/Data.txt");
            WypiszDane();
        }
    }
}