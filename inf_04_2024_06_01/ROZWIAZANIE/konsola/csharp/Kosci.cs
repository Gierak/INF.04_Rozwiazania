class Kosci
{
    public int[] wylosowane = new int[11];
    public int iloscKosci = 0;
    readonly Random random = new();

    public void RzucWszystkimiKoscmi()
    {
        wylosowane = new int[iloscKosci];
        for (int i = 0; i < iloscKosci; i++)
        {
            wylosowane[i] = random.Next(1, 7);
        }
    }

    /************************************************
    nazwa:                  LiczPunkty
    opis:                   Metoda zlicza punkty z tablicy dla elementów które występują więcej niż 2 razy
    parametry:              brak
    zwracany typ i opis:    int - zwracana jest liczba uzyskanych punktów
    autor:                  Karol - Gierak - Gieracki (https://github.com/Gierak)
    ************************************************/
    public int LiczPunkty()
    {
        int suma = 0;
        foreach (IGrouping<int, int> item in wylosowane.GroupBy(i => i))
        {
            if (item.Count() > 1)
            {
                suma += item.Key * item.Count();
            }
        }
        return suma;
    }
}