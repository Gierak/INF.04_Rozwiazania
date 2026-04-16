public class Operacje
{
    private int[] tablica;
    private int liczba_elementow;

    Random random = new Random();

    public Operacje(int rozmiar)
    {
        liczba_elementow = rozmiar;
        tablica = new int[liczba_elementow];
        for (int i = 0; i < liczba_elementow; i++)
        {
            tablica[i] = random.Next(1, 1001);
        }
    }

    public void WyswietlElementy()
    {
        for (int i = 0; i < liczba_elementow; i++)
        {
            Console.WriteLine($"{i}: {tablica[i]}");
        }
    }

    public int PierwszeWystapienie(int szukana)
    {
        for (int i = 0; i < liczba_elementow; i++)
        {
            if (szukana == tablica[i])
            {
                return i;
            }
        }
        return -1;
    }

    public int WyswietlNieparzyste()
    {
        int licz = 0;
        foreach (int liczba in tablica)
        {
            if (liczba % 2 != 0)
            {
                licz++;
                Console.WriteLine(liczba);
            }
        }
        return licz;
    }

    /**********************************************
    nazwa metody:           SredniaArytmetyczna
    opis metody:            Metoda zlicza średnią arytmetyczną wartości w tablicy
    parametry:              brak
    zwracany typ i opis:    float - średnia arytemetyczna z tablicy
    autor:                  Karol - Gierak - Gieracki (https://github.com/Gierak)
    ***********************************************/
    public float SredniaArytmetyczna()
    {
        float suma = 0;
        foreach (int liczba in tablica)
        {
            suma += liczba;
        }
        return suma / liczba_elementow;
    }

}