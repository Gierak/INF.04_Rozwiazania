public class Osoba
{
    private int id;
    private string imie;

    static public int licznik = 0;

    public Osoba()
    {
        id = 0;
        imie = "";
        licznik++;
    }

    public Osoba(int id1, string imie1)
    {
        id = id1;
        imie = imie1;
        licznik++;
    }

    public Osoba(Osoba os)
    {
        id = os.id;
        imie = os.imie;
        licznik++;
    }

    public void Wypisywanie(string imie_przekazane)
    {
        if (string.IsNullOrEmpty(imie))
        {
            Console.WriteLine("Brak danych");
        }
        else
        {
            Console.WriteLine($"Cześć {imie_przekazane}, mam na imię {imie}");
        }
    }

}