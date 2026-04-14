/************************************************
klasa:          Notatka
opis:           Klasa obsługuje obsługę wyświetlania notatki normalnie i diagnostycznie
pola:
        licznik - przechowuje ilość utworzonych obiektów klasy
        id - przechowuje identyfikator notatki
        tytul - przechowuje tytul notatki
        tresc - przechowuj tresc notatki
autor:          Karol - Gierak - Gieracki (https://github.com/Gierak)
************************************************/
public class Notatka
{
    private static int licznik = 0;
    private int id;
    protected string tytul;
    protected string tresc;

    public Notatka(string tytul1, string tresc1)
    {
        licznik++;
        id = licznik;
        tytul = tytul1;
        tresc = tresc1;
    }

    public void Wyswietl()
    {
        Console.Write(Environment.NewLine);
        Console.WriteLine(tytul);
        Console.WriteLine(tresc);
        Console.Write(Environment.NewLine);
    }

    public void Diagnostyczna()
    {
        Console.WriteLine($"{licznik};{id};{tytul};{tresc}");
    }

}