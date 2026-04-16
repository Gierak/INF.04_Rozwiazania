/**********************************************
nazwa funkcji:          WyswietlWyniki
opis funkcji:           Funkcja wyświetla na ekranie użytkownika wyniki losowań
parametry:              dane - tablica dwuwymiarowa z wynikami losowania
zwracany typ i opis:    brak
autor:                  Karol - Gierak - Gieracki (https://github.com/Gierak)
***********************************************/
void WyswietlWyniki(int[,] dane)
{
    for (int i = 0; i < dane.GetLength(0); i++)
    {
        string wiersz = $"Losowanie {i + 1}: ";
        for (int j = 0; j < dane.GetLength(1); j++)
        {
            wiersz += dane[i, j] + " ";
        }
        Console.WriteLine(wiersz);
    }
}

void WypiszIloscWystapien(int[,] dane)
{
    SortedDictionary<int, int> wystapienia = [];
    for (int i = 0; i < dane.GetLength(0); i++)
    {
        for (int j = 0; j < dane.GetLength(1); j++)
        {
            if (wystapienia.ContainsKey(dane[i, j]))
            {
                wystapienia[dane[i, j]]++;
            }
            else
            {
                wystapienia[dane[i, j]] = 1;
            }
        }
    }

    for (int i = 1; i <= 49; i++)
    {
        if (wystapienia.ContainsKey(i))
        {
            Console.WriteLine($"Wystąpienia liczby {i}: {wystapienia[i]}");
        }
        else
        {
            Console.WriteLine($"Wystąpienia liczby {i}: 0");
        }
    }
}

int[] LosujBezPowtorzen(Random random)
{

    int licznik = 0;
    int[] losowanie = new int[6];
    while (licznik < 6)
    {
        int wylosowana = random.Next(1, 50);
        if (!losowanie.Contains(wylosowana))
        {
            losowanie[licznik] = wylosowana;
            licznik++;
        }
    }
    return losowanie;
}

void WypełnijTablice(int[,] dane, Random random)
{
    for (int i = 0; i < dane.GetLength(0); i++)
    {
        int[] wylosowane = LosujBezPowtorzen(random);
        for (int j = 0; j < dane.GetLength(1); j++)
        {
            dane[i, j] = wylosowane[j];
        }
    }
}

Random random = new();

Console.WriteLine("Ile wygenerować losowań?");
int losowan = int.Parse(Console.ReadLine()!);

int[,] tablica = new int[losowan, 6];
WypełnijTablice(tablica, random);
WyswietlWyniki(tablica);
WypiszIloscWystapien(tablica);