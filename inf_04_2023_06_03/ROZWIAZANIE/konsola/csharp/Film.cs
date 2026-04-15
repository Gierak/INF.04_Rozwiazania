/******************************************************
nazwa klasy:    Film
pola:
    tytul - przechowuje tytuł filmu
    liczba_wypozyczen - przechowuje liczbę wypożyczeń filmu
metody:
    Tytul, string – zwraca lub ustawia tytuł filmu
    Liczba_wypozyczen, int – zwraca liczbę wypożyczeń filmu
    InkrementujLiczbeWypozyczen, void – zwiększa liczbę wypożyczeń o 1
informacje:     Klasa przechowuje informacje o filmie i liczbie jego wypożyczeń
autor:          Karol - Gierak - Gieracki (https://github.com/Gierak)
*****************************************************/
public class Film
{
    protected string tytul = "";
    protected int liczba_wypozyczen = 0;

    public string Tytul
    {
        get { return tytul; }
        set { tytul = value; }
    }

    public int Liczba_wypozyczen
    {
        get { return liczba_wypozyczen; }
    }

    public void InkrementujLiczbeWypozyczen()
    {
        liczba_wypozyczen++;
    }

}