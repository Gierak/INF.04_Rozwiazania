public class Sortowanie
{
    public int[] tablica = new int[10];

    /********************************************************
    * nazwa funkcji: SortowaniePrzezWybieranie
    *
    * parametry wejściowe: brak
    * wartość zwracana: brak
    *
    * autor: Karol - Gierak - Gieracki (https://github.com/Gierak)
    * ****************************************************/
    public void SortowaniePrzezWybieranie()
    {
        for (int i = 0; i < tablica.Length - 1; i++)
        {
            int indeks = SzukajWartoscNajwyzsza(i);
            (tablica[i], tablica[indeks]) = (tablica[indeks], tablica[i]);
        }
    }

    /********************************************************
    * nazwa funkcji: SzukajWartoscNajwyzsza
    *
    * parametry wejściowe: od - liczba całkowita które mówi programowi od której liczby ma szukać wartości najwyższej
    * wartość zwracana: funkcja zwraca indeks elementu najwyższego
    *
    * autor: Karol - Gierak - Gieracki (https://github.com/Gierak)
    * ****************************************************/
    private int SzukajWartoscNajwyzsza(int od)
    {
        int indeks = od;
        int wartosc = tablica[od];
        for (int i = od; i < tablica.Length; i++)
        {
            if (tablica[i] > wartosc)
            {
                wartosc = tablica[i];
                indeks = i;
            }
        }
        return indeks;
    }

    public void WypiszTablice()
    {
        Console.WriteLine("\nTablica posortowana:");
        Console.WriteLine(String.Join(',', tablica));
    }
}